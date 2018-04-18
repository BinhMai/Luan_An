using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject
{
    class DTO_TS
    {
        private string _MA_TRUONG;
        private float _NAM;
        private float _CHITIEU;

        public DTO_TS(string MA_TRUONG, float NAM, float CHITIEU)
        {
            _MA_TRUONG = MA_TRUONG;
            _NAM = NAM;
            _CHITIEU = CHITIEU;            
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

        public float NAM
        {
            get
            {
                return _NAM;
            }

            set
            {
                _NAM = value;
            }
        }
        public float CHITIEU
        {
            get
            {
                return _CHITIEU;
            }

            set
            {
                _CHITIEU = value;
            }
        }        
    }
}
