
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3_ex2 {
    class sword : Item {
        public sword() {
            setCost(500);
            setWeight(5);
        }
    }
    class potion : Item {
        public potion() {
            setCost(700);
            setWeight(1);
        }
    }
    class wand : Item {
        public wand() {
            setCost(1000);
            setWeight(2);
        }
    }
    class cloak : Item {
        public cloak() {
            setCost(200);
            setWeight(3);
        }
    }
    class hammer : Item {
        public hammer() {
            setCost(200);
            setWeight(5);
        }
    }
}
