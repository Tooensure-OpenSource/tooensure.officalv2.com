using Google.Cloud.Firestore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooensureApp.Data.Models;

namespace TooensureApp.Data.Data
{
    public class DownloadContext
    {
        string projectId;
        private FirestoreDb fireStoreDb;

        public DownloadContext()
        {
            //string filepath = "https://firestore.googleapis.com/v1/projects/tooensure-online-services/databases/(default)/documents";
            string filepath = "C:\\Users\\tooen\\source\\repos\\tooensure.offical.com\\Data\\tooensure-online-services-firebase-adminsdk-x55h6-5ed509299a.json";

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            projectId = "tooensure-online-services";
            fireStoreDb = FirestoreDb.Create(projectId);
        }

        public async Task<List<Download>> GetDownloads()
        {
            try
            {
                Query downloadQuery = fireStoreDb.Collection("Downloads");
                QuerySnapshot employeeQuerySnapshot = await downloadQuery.GetSnapshotAsync();
                List<Download> Downloads = new List<Download>();

                foreach (DocumentSnapshot documentSnapshot in employeeQuerySnapshot.Documents)
                {
                    if (documentSnapshot.Exists)
                    {
                        Dictionary<string, object> city = documentSnapshot.ToDictionary();
                        string json = JsonConvert.SerializeObject(city);
                        Download newuser = JsonConvert.DeserializeObject<Download>(json);
                        newuser.Id = documentSnapshot.Id;
                        Downloads.Add(newuser);
                    }
                }

                return Downloads;
            }
            catch
            {
                throw;
            }
        }

        public async void UpdateDownload(Download download)
        {
            try
            {
                DocumentReference empRef = fireStoreDb.Collection("Downloads").Document(download.Id);
                await empRef.SetAsync(download, SetOptions.Overwrite);
            }
            catch
            {
                throw;
            }
        }

        public async Task<Download> GetDownloadData(string id)
        {
            try
            {
                DocumentReference docRef = fireStoreDb.Collection("Downloads").Document(id);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    Download dl = snapshot.ConvertTo<Download>();
                    dl.Id = snapshot.Id;
                    return dl;
                }
                else
                {
                    return new Download();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
