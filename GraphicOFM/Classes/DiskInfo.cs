using System;

namespace GraphicOFM.Classes
{
    class DiskInfo
    {
        public DriveInfo[] driveList { get; private set; }
        public DriveInfo[] SetDrivers()
        {
            driveList = DriveInfo.GetDrives();
            return driveList;
        }
    }
}


