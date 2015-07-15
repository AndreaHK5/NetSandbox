using System;
using System.Configuration;

namespace SampleApp.BusinessLayer
{
    public static class BusinessLayerConfig {
        public static AccessType Repository {
            get { return AppGet("SampleApp.Repository.Implementation", AccessType.Persistance); }
        }

        private static T AppGet<T>(String settingName, T defaultValue) where T : struct, IConvertible {
            try
            {
                String value = ConfigurationManager.AppSettings.Get(settingName);
                return (T) Enum.Parse(typeof (T), value, true);
            }
            catch (ConfigurationErrorsException) { return defaultValue; }
            catch (       ArgumentNullException) { return defaultValue; }
            catch (           ArgumentException) { return defaultValue; }
            catch (           OverflowException) { return defaultValue; }
        }
    }
}
