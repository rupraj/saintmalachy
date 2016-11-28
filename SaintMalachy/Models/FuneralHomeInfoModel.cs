using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaintMalachy.Models
{
    public class FuneralHomeInfoModel
    {
        public int FuneralHomeInfoModelId { get; set; }
        public string NameOfDeceased { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfDeath { get; set; }
        public string FuneralHome { get; set; }
        public string DateOfFuneral { get; set; }
        public string TimeOfFuneral { get; set; }
        public string DateOfWake { get; set; }
        public string TimeOfWake { get; set; }
        public string ProcessionalSong { get; set; }
        public string OtherHymns { get; set; }
        public string ResponsorialPsalm { get; set; }
        public string OffertorySong { get; set; }
        public string CommunionSong { get; set; }
        public string RecessionalSong { get; set; }
        public string ReaderOneReading { get; set; }
        public string ReaderTwoReading { get; set; }
        public string PresentationOfGifts { get; set; }
        public string Eulogy { get; set; }
        public string Comments { get; set; }
    }
}