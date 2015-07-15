using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SampleApp {
    public static class APIConfig {
        public static BusinessLayerType Repository {
            get { return AppGet("SampleApp.Services.Implementation", BusinessLayerType.Production); }
        }

        private static T AppGet<T>(String settingName, T defaultValue) where T : struct, IConvertible {
            try
            {
                String value = ConfigurationManager.AppSettings.Get(settingName);
                return (T) Enum.Parse(typeof (T), value, true);
            }
            catch (ConfigurationErrorsException) { return defaultValue; }
            catch (       ArgumentNullException) { return defaultValue; }
            catch (           ArgumentException){ return defaultValue; }
            catch (           OverflowException){ return defaultValue; }
        }
    }
}

