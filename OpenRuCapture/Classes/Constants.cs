namespace OpenRuCapture
{
    public static class Constants
    {
        public const string APP_TITLE = "OpenRuCapture";
        public const string APP_ALREADY_RUNNING = "Еще один экземпляр OpenRuCapture уже запущен";
        public const string APP_EXCEPTION = "Исключение приложения произошло в OpenRuCapture.{0}Сообщите об этом на КонтинентСвободы.рф.";
        public const string APP_URL = "http://КонтинентСвободы.рф";
        public const string ABOUT_MESSAGE = "OpenRuCapture v1.0{0}{0}Разработчик КонтинентСвободы.рф{0}Лицензировано под GNU GPL v2.{0}{0} Домашняя страница: https://КонтинентСвободы.рф";
        public const string APPINFOMESG = "{0} запущен. Правый клик для настроек.";
        public const string SELECTFOLDER = "Выберите папку вывода";
        public const string IMAGEFILTER = "PNG File|*.png|JPEG File|*.jpeg|BMP File|*.bmp|TIFF File|*.tiff|GIF File|*.gif|WMF File|*.wmf";
        public const string SOUNDFILTER = "Sound files(*.wav)|*.wav";
        public const string SELECTSOUND = "Select a wav file";
        public const string IMAGESELECTDLGTITLE = "Выберите файл изображения";
        public const string INITMETHOD = "Initialize";
        public const string EXECUTEMETHOD = "Execute";
        public const string EXIT_CONFIRM = "Запланированный процесс захвата изображений выполняется в фоновом режиме.{0}Если вы выйдете из OpenRuCapture" +
            " это отменит этот процесс.{0}{0}Вы действительно хотите выйти?";
        public const string SETTINGSFILE = "Settings.ini";
        public const string APP_NAME = "OpenRuCapture";
        public const string REGISTRY_LOC = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        public const string IMAGE_SELECT_CONFIRM = "Для этого действия требуется изображение, и в этом сеансе не обнаружено захваченного изображения. Вы хотите просмотреть изображение?";
        public const string HELPFILE = "OpenRuCapturehelp.chm";
        public const string TEMPLATE_HELP = "OpenRuCapture поддерживает следующие заполнения.{0}{0}1.%TICKS% - Дата время тики.(default){0}" +
            "2.%AUTO% -Автоматическое увеличение.{0}3.%DATE% - Дата (текущий системный формат){0}4.%TIME% - Время (текущий системный формат){0}5.%USER% - Вход в систему.{0}" +
            "6.%SYSTEM% - Название машины.{0}{0}Эти владельцы мест будут заменены{0} на фактические значения при завершении захвата.";
        public const string DEFAULT_TEMPLATE = "OpenRuCapture%TICKS%";
        public const string ACTIVEWINDOWCAPTURE_PLUGIN = "OpenRuCapture.Capturemodes.WindowCaptureHelper";
    }
}
