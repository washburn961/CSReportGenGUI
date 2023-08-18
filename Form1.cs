using ReportGen.Helpers;
using ReportGen.Models.CTAnalyzer;
using ReportGen.Models.ITR.OSKF;

namespace ReportGenGUI
{
    public partial class Form1 : Form
    {
        private BindingSource currentTransformerListBindingSource = new BindingSource();
        private BindingSource resistanceListBindingSource = new BindingSource();
        private BindingSource resistanceBindingSource = new BindingSource();
        private BindingSource selectedCurrentTransformerBindingSource = new BindingSource();
        private BindingSource ctaCurrentTransformerListBindingSource = new BindingSource();
        private AC1CurrentTransformerManager ac1CurrentTransformerManager;
        private CTAnalyzerManager ctaManager;

        public CTAnalyzerManager CTAManager
        {
            get { return ctaManager; }
            set { ctaManager = value; }
        }


        public AC1CurrentTransformerManager AC1CurrentTransformerManager
        {
            get { return ac1CurrentTransformerManager; }
            set { ac1CurrentTransformerManager = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resistanceListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceBindingSource.DataSource = resistanceListBox.SelectedItem;
        }

        private void oCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCurrentTransformerBindingSource.DataSource = oCcomboBox.SelectedItem;
            selectedCurrentTransformerBindingSource.DataMember = "Windings";
            resistanceListBox.DataSource = selectedCurrentTransformerBindingSource;
        }

        private void ac1ToolStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"; // Filter for XML files
                openFileDialog.FilterIndex = 1; // Set the default filter index to the first option
                openFileDialog.RestoreDirectory = true; // Remember the last directory

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected file
                    string filePath = openFileDialog.FileName;

                    // Here you can write the code to handle the selected XML file, e.g., read it, process it, etc.
                    // Example:
                    AC1CurrentTransformerManager = new AC1CurrentTransformerManager(filePath);
                    RefreshBindings();
                }
            }
        }

        private void ctaToolStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"; // Filter for XML files
                openFileDialog.FilterIndex = 1; // Set the default filter index to the first option
                openFileDialog.RestoreDirectory = true; // Remember the last directory
                openFileDialog.Multiselect = true; // Allow multiple file selection

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the paths of the selected files
                    List<string> filePaths = openFileDialog.FileNames.ToList();
                    List<List<string>> filePathsList = new List<List<string>>() { filePaths };

                    // Here you can write the code to handle the selected XML files, e.g., read them, process them, etc.
                    // Example:
                    CTAManager = new CTAnalyzerManager(filePathsList);
                    RefreshBindings();
                }
            }
        }

        private void RefreshBindings()
        {
            if (AC1CurrentTransformerManager is not null)
            {
                currentTransformerListBindingSource.DataSource = AC1CurrentTransformerManager.CurrentTransformers;
                oCcomboBox.DataSource = currentTransformerListBindingSource;
                oCcomboBox.DisplayMember = "OC";
                selectedCurrentTransformerBindingSource.DataSource = AC1CurrentTransformerManager.CurrentTransformers[0].Windings;
                resistanceListBox.DataSource = selectedCurrentTransformerBindingSource;
                resistanceListBox.DisplayMember = "WindingLabel";

                temperatureTextBox.DataBindings.Clear();
                rctTemperatureTextBox.DataBindings.Clear();
                resistanceTextBox.DataBindings.Clear();
                rctTextBox.DataBindings.Clear();
                resistanceBindingSource.DataSource = resistanceListBox.Items[0];
                resistanceListBox.SelectedIndex = 0;
                temperatureTextBox.DataBindings.Add("Text", resistanceBindingSource, "ReferenceTemperature");
                rctTemperatureTextBox.DataBindings.Add("Text", resistanceBindingSource, nameof(Winding.CorrectionTemperature));
                resistanceTextBox.DataBindings.Add("Text", resistanceBindingSource, nameof(Winding.MeasuredResistance));
                rctTextBox.DataBindings.Add("Text", resistanceBindingSource, nameof(Winding.TemperatureCorrectedResistance));

                if (CTAManager is not null)
                {
                    AC1CurrentTransformerManager.MeasurementAttributesInitForAll(CTAManager);
                }
            }

            if (CTAManager is not null)
            {
                ctaCurrentTransformerListBindingSource.DataSource = CTAManager.CurrentTransformers[0].Windings;
                ctaEditorListBox.DataSource = ctaCurrentTransformerListBindingSource;
                ctaEditorListBox.DisplayMember = nameof(CTAWindingMeasurements.WindingLabel);


                if (AC1CurrentTransformerManager is not null)
                {
                    AC1CurrentTransformerManager.MeasurementAttributesInitForAll(CTAManager);
                }
            }
        }
    }
}