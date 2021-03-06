﻿using Tofu.Serialization;
using UnityEngine;

namespace Neolithica.MonoBehaviours.Reservations {
    [SavableMonobehaviour(20)]
    public class Reservation : MonoBehaviour {

        private bool ready = false; //if the reserved asset is ready
        private bool acknowledged = false; //i don't know what this is for
        private bool released = false; //if the reservation has been released by the customer
        private bool cancelled = false; //if the reservation has been cancelled by the vendor

        public bool Ready {
            get { return ready; }
            set { ready = value; }
        }

        public bool Acknowledged {
            get { return acknowledged; }
            set { acknowledged = value; }
        }

        public bool Released {
            get { return released; }
            set { 
                released = value;
                if (!released) return;

                if (Application.isPlaying) {
                    Destroy(this);
                }
                else {
                    DestroyImmediate(this);
                }
            }
        }

        public bool Cancelled {
            get { return cancelled;  }
            set { cancelled = value; }
        }
    }
}

