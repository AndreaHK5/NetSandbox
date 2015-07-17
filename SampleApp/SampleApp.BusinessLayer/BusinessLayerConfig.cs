using System;
using System.Configuration;

namespace SampleApp.BusinessLayer
{
    public static class BusinessLayerConfig {
        /// <summary>
        /// TRying to get the type fo implementation. As a standard, default is implemented. 
        /// </summary>
        public static AccessType Repository {
            get { return AppGet("SampleApp.Repository.Implementation", AccessType.Persistance); }
        }

        /// <summary>
        /// Getting the type of Implementation from the config file. Config not present or key not present, default is implemented.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="settingName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
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
