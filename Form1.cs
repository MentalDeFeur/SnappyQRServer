using QRCoder;
using static QRCoder.PayloadGenerator;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using Ical.Net.CalendarComponents;
using System.Runtime.CompilerServices;



namespace SnappyQRServer
{
    public partial class Form1 : Form
    {

        private Ical.Net.CalendarComponents.CalendarEvent calendarEvent;
        private DateTime start;
        private DateTime end;

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
                    int qrCodeSize = Math.Min(pictureBox1.Width / 4, pictureBox1.Height / 4);
                    Bitmap qrCodeImage = qrCode.GetGraphic(qrCodeSize / 20);
                    pictureBox1.Image = qrCodeImage;
                }
            }
        }

        private string CreateICalEvent(string summary, string location, DateTime startDT, DateTime endDT)
        {
            var calendar = new Ical.Net.Calendar();

            calendarEvent = new Ical.Net.CalendarComponents.CalendarEvent
            {
                Summary = summary,
                Location = location,
                Start = new CalDateTime(startDT),
                End = new CalDateTime(endDT),
            };


            calendar.Events.Add(calendarEvent);

            var serializer = new CalendarSerializer();
            return serializer.SerializeToString(calendar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string summary = textBoxSummary.Text;
            string location = textBoxLocation.Text;

            string icalContent = CreateICalEvent(summary, location, start, end);
            GenerateQRCode(icalContent);
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            start = dateTimePickerStart.Value;
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            end = dateTimePickerEnd.Value;
        }
    }
}
