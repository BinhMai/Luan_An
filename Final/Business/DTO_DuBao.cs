using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject
{
    class DTO_DuBao
    {
        private string _MA_TRUONG;                
        private float _TI_LE_DO;
        private int _SO_LAO_DONG;
        private int _NAM;
        private int _DU_BAO_TUYEN_SINH;

        public DTO_DuBao(string MA_TRUONG, float TI_LE_DO, int SO_LAO_DONG, int NAM, int DU_BAO_TUYEN_SINH)
        {
            _MA_TRUONG = MA_TRUONG;
            _TI_LE_DO = TI_LE_DO;
            _SO_LAO_DONG = SO_LAO_DONG;
            _NAM = NAM;
            _DU_BAO_TUYEN_SINH = DU_BAO_TUYEN_SINH;
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

        public float TI_LE_DO
        {
            get
            {
                return _TI_LE_DO;
            }

            set
            {
                _TI_LE_DO = value;
            }
        }
        public int SO_LAO_DONG
        {
            get
            {
                return _SO_LAO_DONG;
            }

            set
            {
                _SO_LAO_DONG = value;
            }
        }
        public int NAM
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
        public int DU_BAO_TUYEN_SINH
        {
            get
            {
                return _DU_BAO_TUYEN_SINH;
            }

            set
            {
                _DU_BAO_TUYEN_SINH = value;
            }
        }
    }
}
