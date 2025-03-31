using QRCoder;
using static QRCoder.PayloadGenerator;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using Ical.Net.CalendarComponents;



namespace SnappyQRServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateQRCode(string icalContent)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(icalContent, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    int qrCodeSize = Math.Min(pictureBox1.Width/4, pictureBox1.Height/4);
                    Bitmap qrCodeImage = qrCode.GetGraphic(qrCodeSize / 20); 
                    pictureBox1.Image = qrCodeImage;
                }
            }
        }

        private string CreateICalEvent(string summary, string location, DateTime start, DateTime end)
        {
            var calendar = new Ical.Net.Calendar();

            var calendarEvent = new Ical.Net.CalendarComponents.CalendarEvent
            {
                Summary = summary,
                Location = location,
                Start = new CalDateTime(start.ToString("yyyy-MM-dd")),
                End = new CalDateTime(end.ToString("yyyy-MM-dd"))
            };


            calendar.Events.Add(calendarEvent);

            var serializer = new CalendarSerializer();
            return serializer.SerializeToString(calendar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string summary = textBoxSummary.Text;
            string location = textBoxLocation.Text;
            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;

            string icalContent = CreateICalEvent(summary, location, start, end);
            GenerateQRCode(icalContent);
        }
    }
}
