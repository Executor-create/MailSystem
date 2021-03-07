using System;
using System.Collections.Generic;
using System.Text;

namespace MainMail
{
    class Parcel : IParcel
    {
        private string parcelName;
        private float volumeParcel;
        private float priceParcel;
        private int identify;

        public Parcel(string parcelName, float volumeParcel, float priceParcel, int identify)
        {
            this.parcelName = parcelName;
            this.volumeParcel = volumeParcel;
            this.priceParcel = priceParcel;
            this.identify = identify;
        }

        public string Name()
        {
            return parcelName;
        }

        public float Volume()
        {
            return volumeParcel;
        }

        public float Price()
        {
            return priceParcel;
        }
    }
}