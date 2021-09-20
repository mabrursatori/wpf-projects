using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetConfig.models
{
    class ConfigSetting
    {
        public int SplashScreenTimer { get; set; }
        public int NextQueueTimer { get; set; }
        public bool TopMost { get; set; }

        public int RunningTextSpeed { get; set; }
        public string RunningTextDirection { get; set; }
        public string RunningTextPosition { get; set; }
        public string RunningTextBackground { get; set; }
        public int RunningTextOpacity { get; set; }
        public int RunningTextSeparatorThickness { get; set; }
        public string RunningTextSeparatorColor { get; set; }
        public string DateClockPosition { get; set; }
        public string DateClockBackground { get; set; }
        public int DateClockOpacity { get; set; }
        public string DateClockBorderColor { get; set; }
        public int DateClockBorderOpacity { get; set; }
        public string DateClockFontColor { get; set; }
        public int DateClockFontOpacity { get; set; }
        public int DateClockBorderThickness { get; set; }
        public int DateClockCornerRadius { get; set; }
        public string DateTimeFormat { get; set; }
        public int QueueBubbleType { get; set; }
        public int QueueBubbleWidth { get; set; }
        public int QueueBubbleRow { get; set; }
        public int QueueBubbleColumn { get; set; }
        public string QueueBubblePosition { get; set; }
        public bool QueueBubbleScrolling { get; set; }
        public int QueueBubbleScrollingInterval { get; set; }
        public int QueueBubbleScrollingIntervalWaitingList { get; set; }
        public string QueueBubbleBackground1 { get; set; }
        public int QueueBubbleOpacity1 { get; set; }
        public string QueueBubbleBackground2 { get; set; }
        public int QueueBubbleOpacity2 { get; set; }
        public int QueueTextOrderType { get; set; }
        public int QueueBubbleSeparatorThickness { get; set; }
        public string QueueBubbleSeparatorColor { get; set; }
        public int QueueBubbleCornerRadius { get; set; }
        public string Currentlyservingbackground { get; set; }
        public string Currentlyservingfontcolor { get; set; }
        public string FirstQueueBubbleFontColor { get; set; }
        public string SecondQueueBubbleFontColor { get; set; }
        public string WaitingListFontColor { get; set; }
        public string WaitingListBackground { get; set; }
        public int WaitingListOpacity { get; set; }
        public int WaitingListOpacity2 { get; set; }
        public string WaitingListSeparatorThickness { get; set; }
        public string WaitingListSeparatorColor { get; set; }
        public int WaitingListCornerRadius { get; set; }
        public int WaitingListRow { get; set; }
        public bool WaitingListScroll { get; set; }
        public bool MainDisplayVisibilityBool { get; set; }
        public string MainDisplayContent { get; set; }
        public string MainDisplayBackground { get; set; }
        public int MainDisplayOpacity { get; set; }
        public string MainDisplayMediaStretch { get; set; }
        public string AnnouncementBackground { get; set; }
        public int AnnouncementOpacity { get; set; }
        public string AnnouncementFontColor { get; set; }
        public bool ShowAnnouncement { get; set; }
        public string Protocol { get; set; }
        public string DeviceId { get; set; }
        public string IpServer { get; set; }
        public string PortServer { get; set; }
        public string ApiName { get; set; }
        public string AppName { get; set; }
        public bool BypassCertificate { get; set; }
        public string AppVersionApiUri { get; set; }
        public string ConfigSettingApiUri { get; set; }
        public string DisplayParameterApiUri { get; set; }
        public string TickerPlaylistApiUri { get; set; }
        public string MultimediaPlaylistApiUri { get; set; }
        public string WaitingListApiUri { get; set; }
        public string TotalTicketWaitingListApiUri { get; set; }
        public string TicketAnnouncementApiUri { get; set; }

        private bool _setTicketAfterAnnouncement = true;
        public bool SetTicketAfterAnnouncement { get { return _setTicketAfterAnnouncement; } set { _setTicketAfterAnnouncement = value; } }

        public string AfterTicketAnnouncementApiUri { get; set; }
        public string CheckQueueStatusApiUri { get; set; }
        public bool WriteLogs { get; set; }
        public int KeepLogsFile { get; set; }
        public string OpenOperationHour { get; set; }
        public string CloseOperationHour { get; set; }
        public string StartBreakHour { get; set; }
        public string EndBreakHour { get; set; }

        // added by Sun An - 11 Feb 2021
        public string TotalTicketWaitingApiUri { get; set; }

    }
}
