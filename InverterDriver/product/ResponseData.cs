using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InverterDriver.product
{
    enum ResponseDataIndex
    {
        systemStatus = 3,
        functionStatus = 4,
        driveError1 = 12,
        driveError2 = 13,
        driveError3 = 14,
        driveError4 = 15,
        outdoorUnitProtection = 17,
        compressorTargetSpeedRpmLow = 52,
        compressorTargetSpeedRpmHigh = 53,
        compressorActualSpeedRpmLow = 54,
        compressorActualSpeedRpmHigh = 55,
        outdorrFanTargetSpeedLow = 56,
        outdorrFanTargetSpeedHigh = 57,
        outdorrFanActualSpeedLow = 58,
        outdorrFanActualSpeedHigh = 59,
        acVoltRmsLow = 60,
        acVoltRmsHigh = 61,
        dcVoltRmsLow = 62,
        dcVoltRmsHigh = 63,
        acCurrentRmsLow = 64,
        acCurrentRmsHigh = 65,
        acInputActivePowerLow = 66,
        acInputActivePowerHigh = 67,
        compressorCurrentRmsLow = 68,
        compressorCurrentRmsHigh = 69,
        fanCurrentRmsLow = 82,
        fanCurrentRmsHigh = 83,
        checksum = 127,
    }

    internal class Constants
    {
        static public int responseDataSize = 128;
    }
    
    public class ResponseData
    {
        byte[] responseData = new byte[Constants.responseDataSize];

        ResponseData()
        {
            
        }
            
    }
}
