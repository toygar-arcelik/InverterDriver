using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
        outdoorFanTargetSpeedLow = 56,
        outdoorFanTargetSpeedHigh = 57,
        outdoorFanActualSpeedLow = 58,
        outdoorFanActualSpeedHigh = 59,
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
        public byte[] responseData = new byte[Constants.responseDataSize];
        readonly string _defaultString = "default";

        public ResponseData()
        {
            
        }

        public string GetSystemStatus()
        {
            switch (responseData[ResponseDataIndex.systemStatus.GetHashCode()])
            {
                case 1:
                    return "Standby";
                case 2:
                    return "Running";
                case 4:
                    return "Error";
                case 8:
                    return "Warm up";
                case 16:
                    return "Self-test";
                default:
                    return _defaultString;
            }
        }
        public string GetFunctionStatus()
        {
            switch (responseData[ResponseDataIndex.functionStatus.GetHashCode()])
            {
                case 1:
                    return "PFC operation";
                case 2:
                    return "Motor running";
                case 4:
                    return "Motor limited frequency operation";
                case 8:
                    return "Fan operation";
                default:
                    return _defaultString;
            }
        }
        public int GetCompressorTargetSpeed()
        {
            int _speed = 0;
            _speed |= (responseData[ResponseDataIndex.compressorTargetSpeedRpmHigh.GetHashCode()] << 8);
            _speed |= responseData[ResponseDataIndex.compressorTargetSpeedRpmLow.GetHashCode()];
            return _speed;
        }
        public int GetCompressorActualSpeed()
        {
            int _speed = 0;
            _speed |= responseData[ResponseDataIndex.compressorActualSpeedRpmHigh.GetHashCode()] << 8;
            _speed |= responseData[ResponseDataIndex.compressorActualSpeedRpmLow.GetHashCode()];
            return _speed;
        }
        public int GetOutdoorFanTargetSpeed()
        {
            int _speed = 0;
            _speed |= responseData[ResponseDataIndex.outdoorFanTargetSpeedHigh.GetHashCode()] << 8;
            _speed |= responseData[ResponseDataIndex.outdoorFanTargetSpeedLow.GetHashCode()];
            return _speed;
        }
        public int GetOutdoorFanActualSpeed()
        {
            int _speed = 0;
            _speed |= responseData[ResponseDataIndex.outdoorFanActualSpeedHigh.GetHashCode()] << 8;
            _speed |= responseData[ResponseDataIndex.outdoorFanActualSpeedLow.GetHashCode()];
            return _speed;
        }
        

        
    }
}