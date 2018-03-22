using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject
{
    class DTO_CT
    {
        private int _NAM;
        private int _CHITIEU;

        public DTO_CT(int NAM, int CHITIEU)
        {
            _NAM = NAM;
            _CHITIEU = CHITIEU;
        }

        /* ======== GETTER/SETTER ======== */
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

        public int CHITIEU
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
