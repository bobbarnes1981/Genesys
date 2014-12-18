using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GenesysLibrary;

namespace GenesysGUI
{
    public partial class FormExperiment : Form
    {
        private OpenFileDialog m_fileDialog = new OpenFileDialog();

        private Grid m_grid;

        private decimal m_crossover;

        private decimal m_mutation;

        private decimal m_percentage;

        private int m_population;

        private int m_generations;

        private Thread m_thread;

        private Experiment m_experiment;
        
        public FormExperiment()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (m_fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                m_grid = new Grid(m_fileDialog.FileName, Convert.ToInt32(numericUpDownLimit.Value));
                textBoxPath.Text = m_fileDialog.FileName;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            run();
        }

        private void run()
        {
            disableUI();
            m_crossover = numericUpDownCrossover.Value;
            m_mutation = numericUpDownMutation.Value;
            m_percentage = numericUpDownBreeders.Value;
            m_population = Convert.ToInt32(numericUpDownPopulation.Value);
            m_generations = Convert.ToInt32(numericUpDownGenerations.Value);
            m_thread = new Thread(Worker);
            m_thread.Start();
        }

        private void disableUI()
        {
            numericUpDownBreeders.Enabled = false;
            numericUpDownCrossover.Enabled = false;
            numericUpDownGenerations.Enabled = false;
            numericUpDownLimit.Enabled = false;
            numericUpDownMutation.Enabled = false;
            numericUpDownPopulation.Enabled = false;
            buttonRun.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void stop()
        {
            m_experiment.Stop();
            enableUI();
        }

        private void enableUI()
        {
            if (InvokeRequired)
            {
                BeginInvoke((System.Action) (() => enableUI()));
            }
            else
            {
                numericUpDownBreeders.Enabled = true;
                numericUpDownCrossover.Enabled = true;
                numericUpDownGenerations.Enabled = true;
                numericUpDownLimit.Enabled = true;
                numericUpDownMutation.Enabled = true;
                numericUpDownPopulation.Enabled = true;
                buttonRun.Enabled = true;
                buttonStop.Enabled = false;
            }
        }

        private void Worker()
        {
            Breeder breeder = new Breeder(m_grid, m_crossover, m_mutation, m_percentage);
            m_experiment = new Experiment(breeder, m_population);
            m_experiment.StatusChangedHandler += experimentOnStatusChangedHandler;
            //m_experiment.TaskEvaluatedHandler += experimentOnTaskEvaluatedHandler;
            m_experiment.GenerationCompleteHandler += experimentOnGenerationCompleteHandler;
            m_experiment.Run(m_generations);
            stop();
        }

        private void UpdateProgress(int value)
        {
            if (InvokeRequired)
            {
                BeginInvoke((System.Action)(() => UpdateProgress(value)));
            }
            else
            {
                toolStripProgressBarRun.Value = value;
            }
        }

        private void UpdateStatus(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke((System.Action)(() => UpdateStatus(text)));
            }
            else
            {
                toolStripStatusLabelStatus.Text = text;
            }
        }

        private void UpdateGenerations(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke((System.Action)(() => UpdateGenerations(text)));
            }
            else
            {
                toolStripStatusLabelGenerations.Text = text;
            }
        }

        private void experimentOnStatusChangedHandler(object sender, StatusChangedEventArgs statusChangedEventArgs)
        {
            UpdateStatus(statusChangedEventArgs.Text);
        }

        private void experimentOnTaskEvaluatedHandler(object sender, TaskEvaluatedEventArgs taskEvaluatedEventArgs)
        {
            UpdateProgress((taskEvaluatedEventArgs.Task / m_population) * 100);
            UpdateStatus(string.Format("Evaluating {0}/{1}", taskEvaluatedEventArgs.Task, m_population));
        }

        private void experimentOnGenerationCompleteHandler(object sender, GenerationCompleteEventArgs generationCompleteEventArgs)
        {
             UpdateGenerations(string.Format("{0}/{1} [{2}]", generationCompleteEventArgs.Generation, m_generations, generationCompleteEventArgs.MaxScore));
        }
    }
}
