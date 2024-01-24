using System.Globalization;
using System.IO;
using System.Windows;
using CsvHelper;
using Microsoft.Win32;
using NewDataTO;
using NewDataTO.Model;
using NewDataTO.Service;

namespace student_Score_Manager
{
    public partial class MainWindow : Window
    {
        public List<ScoreDataModel> ScoreData { get; set; }
        public ScoreDataService _scoreDataService;
        public ScoreDataStatisticsService _scoreDataStatistics;

        public MainWindow()
        {
            _scoreDataStatistics = new ScoreDataStatisticsService();
            _scoreDataService = new ScoreDataService();
            InitializeComponent();
        }

        private void LoadData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                ScoreData = csv.GetRecords<ScoreDataModel>().ToList();
            }
            dataListView.ItemsSource = ScoreData;
        }

        private void BrowseFilesBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                UpdateFilePath(filePath);
                LoadData(filePath);
            }
        }

        private void UpdateFilePath(string filePath)
        {
            PathTxt.Text = filePath;
        }
        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            _scoreDataService.AddMany(ScoreData);
        }

        private void Show_Statisics_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OtherOtherDatabaseContext())
            {
                var scoreDataLoader = new ScoreDataLoader(context);

                // Load statistics from the database
                List<ScoreDataStatistics> yearlyStatistics = scoreDataLoader.LoadStatistics();
                ScoreDataStatisticsListView.ItemsSource = yearlyStatistics;
            }
        }
    }
}
