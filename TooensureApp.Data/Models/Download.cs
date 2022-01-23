using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooensureApp.Data.Models
{
    [FirestoreData]
    public class Download
    {
        public string Id { get; set; }
        [FirestoreProperty]
        public int Current { get; set; }
        [FirestoreProperty]
        public int Desired { get; set; }
        [FirestoreProperty]
        public int ExpectedDate { get; set; }
    }
}
