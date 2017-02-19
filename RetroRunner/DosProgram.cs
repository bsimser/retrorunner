using System;
using System.Collections.Generic;

namespace RetroRunner
{
    /// <summary>
    /// Represents a single game or DOS application, along
    /// with its information, settings, and statistics.
    /// </summary>
    [Serializable]
    public class DosProgram
    {
        /// <summary>
        /// The name of the program as it appears in the UI.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The full text description of the program.  Most often, this is
        /// a description from Wikipedia or MobyGames.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The path of the executable file that will be launched using DOSBox
        /// to run this program.
        /// </summary>
        public string ExeName { get; set; }

        /// <summary>
        /// Any command line parameters needed when launching this program.
        /// </summary>
        public string ExeParameters { get; set; }

        /// <summary>
        /// Any commands that should be executed by DOSBox prior to launching this program.
        /// </summary>
        public string ExeInitialCommand { get; set; }

        /// <summary>
        /// The path of the setup or install file for this program.
        /// </summary>
        public string SetupName { get; set; }

        /// <summary>
        /// Any command line parameters needed when launching the setup/install file.
        /// </summary>
        public string SetupParameters { get; set; }

        /// <summary>
        /// Any commands that should be executed by DOSBox prior to launching the setup/install file.
        /// </summary>
        public string SetupInitialCommand { get; set; }

        /// <summary>
        /// The individual or company responsible for developing this program.
        /// </summary>
        public string Developer { get; set; }

        /// <summary>
        /// The individual or company responsible for publication or
        /// distribution of this program.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// The year in which this program was first released.
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// The genre to which this program belongs.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// A screenshot showing normal operation of this program.
        /// </summary>
        public string Screenshot { get; set; }

        /// <summary>
        /// An image displaying the box or packaging for this program.
        /// </summary>
        public string BoxArt { get; set; }

        /// <summary>
        /// Indicates whether a custom DOSBox configuration file is
        /// used for this program.
        /// </summary>
        public bool HasCustomConfFile { get; set; }

        /// <summary>
        /// If a custom DOSBox configuration file is in use for this program,
        /// this indicates the config file path.
        /// </summary>
        public string CustomConfName { get; set; }

        /// <summary>
        /// The number of times this program has been launched.
        /// </summary>
        public int TimesPlayed { get; set; }

        /// <summary>
        /// The last time this program was launched.
        /// </summary>
        public DateTime LastPlayed { get; set; }

        /// <summary>
        /// Indicates whether a help or documentation URL is available
        /// for this program.
        /// </summary>
        public bool HasUrl { get; set; }

        /// <summary>
        /// The help or documentation URL that is associated with this program.
        /// When Wikipedia has been used to fill program info for a game, this
        /// link points to the game's Wikipedia page.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Indicates whether the DOSBox console should be visible when
        /// the program is launched.
        /// </summary>
        public bool HideConsole { get; set; }

        public bool ListedInWikipedia { get; set; }

        public string OriginalName { get; set; }

        public string WikiPage { get; set; }

        public BootDriveInfo BootDrives { get; set; }

        public List<MountedDrive> MountedDrives { get; set; }

        public bool ScreenshotExists()
        {
            return true;
        }

        public bool BoxArtExists()
        {
            return true;
        }

        public bool ExeFileExists()
        {
            return true;
        }

        public bool SetupFileExists()
        {
            return true;
        }

        public bool CustomConfFileExists()
        {
            return true;
        }

        public bool ExeDirectoryExists()
        {
            return true;
        }

        public string ExeDirectory()
        {
            return string.Empty;
        }

        public static void AddProgram()
        {
            using (var programWizard = new ProgramWizard())
            {
                programWizard.ShowDialog();
            }
        }

        public static void EditProgram()
        {
            using (var programWizard = new ProgramWizard())
            {
                programWizard.ShowDialog();
            }
        }

        public static void DeleteProgram()
        {
        }

        public static void ResetPlayInfo()
        {
        }

        public static void CreateCustomConfigFile()
        {
        }

        public static void EditCustomConfigFile()
        {
        }

        public static void DeleteCustomConfigFile()
        {
        }
    }
}