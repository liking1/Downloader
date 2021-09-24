using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Downloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<FileInfo> files = new ObservableCollection<FileInfo>();
        public string FileName { get; set; }
        public string Url { get; set; }
        int number = 0;

        public MainWindow()
        {
            InitializeComponent();
            number = new Random().Next(1, 100);
            lbOutput.ItemsSource = files;
        }
        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lbOutput.SelectedItem != null)
                {
                    var selected = lbOutput.SelectedItem as FileInfo;
                    if (selected.IsPause)
                    {
                        (lbOutput.SelectedItem as FileInfo).ResetEvent.Reset();
                    }
                    else
                    {
                        (lbOutput.SelectedItem as FileInfo).ResetEvent.Set();
                    }
                    return;
                }
                MessageBox.Show("Please, select an item!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lbOutput.SelectedItem == null)
                {
                    MessageBox.Show("Select item!");
                }
                else
                {
                    (lbOutput.SelectedItem as FileInfo).client.CancelAsync();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            if (tbPath.Text == string.Empty)
                MessageBox.Show("Empty");
            else
                await Handler();

        }

        private string GetFileExtension(string fileName)
        {
            string extension = "";
            char[] arr = fileName.ToCharArray();
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '.'
            )
                {
                    index = i;
                }
            }
            for (int x = index + 1; x < arr.Length; x++)
            {
                extension = extension + arr[x];
            }
            return extension;
        }

        Task Handler()
        {
            WebClient client = new WebClient();
            FileInfo info = new FileInfo()
            {
                FolderName = tbPath.Text,
                Progress = 0,
                client = client
            };

            client.DownloadProgressChanged += (s, el) => { info.Progress = el.ProgressPercentage; };
            client.DownloadFileAsync(new Uri(tbPath.Text), $"File{number}." + GetFileExtension(tbPath.Text));
            files.Add(info);
            return Task.CompletedTask;
        }

        private static void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Canceled!");
            else
                MessageBox.Show("File has been downloaded succesfully!");
        }
        //Task Rename()
        //{
        //    
        //}
        private void btnRename_Click(object sender, RoutedEventArgs e)
        {
            string filePath = $"File{number}.zip";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                //lbOutput.SelectedItems.Remove(lbOutput.SelectedItems);
                MessageBox.Show("Folder Deleted");
            }
            else
            {
                MessageBox.Show("Folder in not exists");
            }
            //if (File.Exists(tbPath.Text))
            //{
            //    File.Delete(lbOutput.SelectedItem.ToString());
            //}

        }
    }
}
