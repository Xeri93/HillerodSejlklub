using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Codet af Max
namespace HillerodSejlklub
{
    public class VedligeholdelseslogRepo
    {
        private List<Vedligeholdelseslog> logs;

        public VedligeholdelseslogRepo()
        {
            logs = new List<Vedligeholdelseslog>();
        }

        // Create
        public void CreateLog(Vedligeholdelseslog log)
        {
            logs.Add(log);
        }

        // Read
        public List<Vedligeholdelseslog> ReadLog(int bådId)
        {
            List<Vedligeholdelseslog> result = new List<Vedligeholdelseslog>();
            foreach (var log in logs)
            {
                if (log.BådId == bådId)
                {
                    result.Add(log);
                }
            }
            return result;
        }

        // Update
        public bool UpdateLog(int logId, Vedligeholdelseslog updatedLog)
        {
            foreach (Vedligeholdelseslog log in logs)
            {
                if (log.LogId == logId)
                {
                    log.LogId = updatedLog.LogId;
                    log.BådId = updatedLog.BådId;
                    log.Dato = updatedLog.Dato;
                    log.Beskrivelse = updatedLog.Beskrivelse;
                    log.UdførtAf = updatedLog.UdførtAf;
                    return true;
                }
            }
            return false;
        }

        // Delete
        public bool DeleteLog(int logId)
        {
            foreach (var log in logs)
            {
                if (log.LogId == logId)
                {
                    return logs.Remove(log);
                }
            }
            return false;
        }
    }
}


