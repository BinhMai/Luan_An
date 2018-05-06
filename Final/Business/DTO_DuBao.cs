using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject
{
    class DTO_DuBao
    {
        private string _MA_TRUONG;                
        private float _TILE;
        private int _DU_BAO;
        private int _NAM;
        private int _CHI_TIEU;

        public DTO_DuBao(string MA_TRUONG, float TI_LE, int DU_BAO, int NAM, int CHI_TIEU)
        {
            _MA_TRUONG = MA_TRUONG;
            _TILE = TI_LE;
            _DU_BAO = DU_BAO;
            _NAM = NAM;
            _CHI_TIEU = CHI_TIEU;
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

        public float TILE
        {
            get
            {
                return _TILE;
            }

            set
            {
                _TILE = value;
            }
        }
        public int DU_BAO
        {
            get
            {
                return _DU_BAO;
            }

            set
            {
                _DU_BAO = value;
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
        public int CHI_TIEU
        {
            get
            {
                return _CHI_TIEU;
            }

            set
            {
                _CHI_TIEU = value;
            }
        }
    }
}
