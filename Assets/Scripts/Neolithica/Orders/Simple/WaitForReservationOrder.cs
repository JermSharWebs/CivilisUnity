﻿using Neolithica.MonoBehaviours;
using Neolithica.MonoBehaviours.Reservations;

namespace Neolithica.Orders.Simple {
    public class WaitForReservationOrder : IdleOrder {
        private Reservation reservation;

        public WaitForReservationOrder(ActorController a, Reservation r) : base(a) {
            a.GetComponent<NeolithicObject>().statusString = "Waiting for reservation";
            reservation = r;
        }

        public override void DoStep() {
            base.DoStep();
            if (reservation.Ready) {
                Completed = true;
            }
        }


    }
}
