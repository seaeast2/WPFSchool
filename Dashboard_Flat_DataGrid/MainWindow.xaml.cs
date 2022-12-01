using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.ObjectModel;

namespace Dashboard_Flat_DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // 런타임 오류가 나면 Debug/Image/man.jpg 복사
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            // Create DataGrid Item Info
            members.Add(new Member { Number = "1", Character = "ㄱ", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "김방구", Position = "코치", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "2", Character = "ㄱ", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "김말뚝", Position = "매니저", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "3", Character = "ㄱ", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "김빡통", Position = "코치", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "4", Character = "ㄷ", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "대갈통", Position = "관리자", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "5", Character = "ㅂ", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "방구맨", Position = "매니저", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "6", Character = "ㅇ", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "오징어", Position = "매니저", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "7", Character = "ㅇ", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "이지랄", Position = "코치", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "8", Character = "ㅇ", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "오늘도", Position = "관리자", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "9", Character = "ㅎ", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "하랄랄", Position = "매니저", Email = "aa@gmail.com", Phone = "010-9997-0875" });
            members.Add(new Member { Number = "10", Character = "ㅈ", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "장삼봉", Position = "코치", Email = "aa@gmail.com", Phone = "010-9997-0875" });

            membersDataGrid.ItemsSource = members;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }
    }

    public class Member
    {
        public string? Character { get; set; }
        public string? Number { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Brush? BgColor { get; set; }
    }
}
