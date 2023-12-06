using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneServices
{  
        public class FileManage<T> where T : class, new()
        {
        public static void WriteOnFile(string path, List<T> data)
        {
            List<String> list = new List<String>();
            StringBuilder MediaDataFlow = new StringBuilder();
            var cols = data[0].GetType().GetProperties();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            foreach (var col in cols)
            {
                    MediaDataFlow.Append(col.Name);
                    MediaDataFlow.Append(',');
            }
            list.Add(MediaDataFlow.ToString().Substring(0, MediaDataFlow.Length - 1));

            foreach (var row in data)
            {
                    MediaDataFlow = new StringBuilder();
                foreach (var col in cols)
                {
                        MediaDataFlow.Append(col.GetValue(row));
                        MediaDataFlow.Append(",");
                }
                list.Add(MediaDataFlow.ToString().Substring(0, MediaDataFlow.Length - 1));
            }
            File.AppendAllLines(path, list);
        }
        public static List<T> CreateObject(List<string> csv)
        {
            List<T> list = new List<T>();
            string[] headers = csv.ElementAt(0).Split(',');// Header
            csv.RemoveAt(0); // Rimuovo la prima riga (nome colonne) del mio datasource

            bool isDatset = true;
            T entry = new T(); // Creo istanza per poter estrarre le properties
            PropertyInfo[] prop = entry.GetType().GetProperties(); // Prendo le sue properties 

            if (isDatset)
            {
                //VERIFICO SE IL FILE CARICATO HA LA LO STESSO DATASET DELL'OGGETTO T
                for (int i = 0; i < prop.Length; i++) // Ciclo le properties dell'oggetto  T
                {
                    if (prop.ElementAt(i).Name == headers[i]) // ciclo le colonne e le properties insieme non col stesso index
                    {
                        continue;
                    }
                    else
                    {
                        isDatset = false; // Se fallisce almeno una volta , non il dataset. 
                    }
                }
            }
            if (isDatset)
            {
                // INIZIO AD ESTRARRE LE RIGHE CON I DATI  
                csv.RemoveAt(0); // Rimuovi la prima riga che raprensenta il HEADER [Name,Age]
                foreach (var line in csv)
                {
                    entry = new T();// Per ogni riga del CSV creo un nuovo oggetto di tipo T

                    #region eXTRACION
                    int j = 0;
                    string[] columns = line.Split(',');

                    foreach (var col in columns) // cicle le colonne del CSV
                    {
                        try
                        {
                            entry.GetType().GetProperty(headers[j]) // prendo  proprietà dell'oggetto Person  tramite i nomi delle colonne del file 
                              .SetValue(entry, // Vado a settare il valore predendo invece il valore della cella che corrisponde alla colonna 
                                 Convert.ChangeType(col, //   singola cella del CSV (il valore da settare )
                                     entry.GetType().GetProperty(headers[j])
                                       .PropertyType)  //ritorna il tipo del property dell'oggetto. Mi server per convertire il valore che in qeusto momento non altro che una stringa dal file. 
                              );
                        }
                        catch
                        {
                            throw;
                        }
                        j++;
                    }
                    #endregion

                    list.Add(entry);
                }
            }
            else Console.WriteLine("Errore: Oggetto e File Csv hanno Dataset diversi!");

            return list;
        }
    }
}


