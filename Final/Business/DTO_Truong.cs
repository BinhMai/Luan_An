using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject
{
    class DTO_Truong
    {
        private string _MA_TRUONG;
        private string _TEN_TRUONG;
        private string _DIA_CHI;
        private string _WEBSITE;
        private string _TINH_THANH;
        private string _DV_CHU_QUAN;

        public DTO_Truong(string MA_TRUONG, string TEN_TRUONG, string DIA_CHI, string WEBSITE, string TINH_THANH, string DV_CHU_QUAN)
        {
            _MA_TRUONG = MA_TRUONG;
            _TEN_TRUONG = TEN_TRUONG;
            _DIA_CHI = DIA_CHI;
            _WEBSITE = WEBSITE;
            _TINH_THANH = TINH_THANH;
            _DV_CHU_QUAN = DV_CHU_QUAN;
        }

        /* ======== GETTER/SETTER ======== */
        public string MA_TRUONG
        {
            get
            {
                return _MA_TRUONG;
            }

            set
            {
                _MA_TRUONG = value;
            }
        }

        public string TEN_TRUONG
        {
            get
            {
                return _TEN_TRUONG;
            }

            set
            {
                _TEN_TRUONG = value;
            }
        }
        public string DIA_CHI
        {
            get
            {
                return _DIA_CHI;
            }

            set
            {
                _DIA_CHI = value;
            }
        }
        public string WEBSITE
        {
            get
            {
                return _WEBSITE;
            }

            set
            {
                _WEBSITE = value;
            }
        }
        public string TINH_THANH
        {
            get
            {
                return _TINH_THANH;
            }

            set
            {
                _TINH_THANH = value;
            }
        }
        public string DV_CHU_QUAN
        {
            get
            {
                return _DV_CHU_QUAN;
            }

            set
            {
                _DV_CHU_QUAN = value;
            }
        }
    }
}
