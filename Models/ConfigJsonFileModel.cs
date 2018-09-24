using BitBotBackToTheFuture.Enums;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBotBackToTheFuture.Models
{
    class ConfigJsonFileModel
    {
        public string bitmexKey { get; set; }
        public string bitmexSecret { get; set; }
        public string bitmexKeyWeb { get; set; }
        public string bitmexSecretWeb { get; set; }
        public string timeGraph { get;  set; }
        public string statusShort { get; set; }
        public string statusLong { get; set; }
        public string pair { get;  set; }
        public int qtdyContacts { get;  set; }
        public int interval { get;  set; }
        public int intervalOrder { get;  set; }
        public int intervalCapture { get;  set; }
        public int intervalCancelOrder { get;  set; }
        public int positionContracts { get; set; }
        public double profit { get;  set; }
        public int limiteOrder { get;  set; }
        public double fee { get;  set; }
        public double stoploss { get;  set; }
        public double stopgain { get;  set; }
        public string bitmexDomain { get;  set; }
        public bool roeAutomatic { get;  set; }
        public string webserverConfig { get;  set; }
        public bool webserver { get;  set; }
        public List<IndicatorsEntry> indicatorsEntry { get;  set; }
        public List<IndicatorsEntry> indicatorsEntryCross { get;  set; }
        public List<IndicatorsEntry> indicatorsEntryDecision { get;  set; }
       
        internal string getValue(IndicatorsEntryType indicatorsEntryType, String nameIndicator, String nameParameter)
        {
            List<IndicatorsEntry> toInterator;
            switch (indicatorsEntryType) {
                case IndicatorsEntryType.INDICATORS_ENTRY:
                    toInterator = indicatorsEntry;
                    break;
                case IndicatorsEntryType.INDICATORS_ENTRY_CROSS:
                    toInterator = indicatorsEntryCross;
                    break;
                case IndicatorsEntryType.INDICATORS_ENTRY_DECISION:
                    toInterator = indicatorsEntryDecision;
                    break;
                default:
                    return null;
            }
            foreach (var item in toInterator)
                if (item.name.ToString().Trim().ToUpper() == nameIndicator.ToUpper().Trim())
                    switch (nameParameter)
                    {
                        case "tendency":
                            return item.tendency.ToString().Trim();
                            break;
                        case "decision":
                            return item.decision.ToString().Trim();
                            break;
                        case "decisionPoint":
                            return item.decisionPoint.ToString().Trim();
                            break;
                    }
            return null;
        }

    }
}
