namespace BANANA
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Windows.Threading;

    [DefaultMember("Item")]
    internal class ActorList : IEnumerable<Actor>, IEnumerable
    {
        public static ulong nextActorAddress32;
        private DispatcherTimer updateTimer = new DispatcherTimer();
        private Dictionary<ulong, Actor> addressToActorDB = new Dictionary<ulong, Actor>();
        public static ulong nextActorAddress64;

        public ActorList()
        {
            this.updateTimer.Tick += new EventHandler(this.update);
            if (this.updateTimer.Interval.TotalMilliseconds != 400.0)
            {
                this.updateTimer.Interval = new TimeSpan(0, 0, 0, 0, 400);
            }
        }

        public IEnumerator<Actor> GetEnumerator()
        {
            return this.addressToActorDB.Values.GetEnumerator();
        }

        public void MDEMLFCLHAJXIEPJAANIVE()
        {
            this.updateTimer.Start();
        }

        public void update(object sender, EventArgs e)
        {
            if (BotMain.bits == "x64")
            {
                nextActorAddress64 = Memory.readUInt64(((long) Memory.readUInt64(Memory.PYHKTUBUVKULYYDMTKRMRB + UNKNOWN_maybe_LocalPlayer.RQKCVGGBUIRNTGOCZCZWJR)) + 0x7498L);
                while (nextActorAddress64 != 0L)
                {
                    this.addressToActorDB[nextActorAddress64] = new Actor(nextActorAddress64);
                    nextActorAddress64 = Memory.readUInt64(((long) nextActorAddress64) + 0x60L);
                }
            }
            else if (BotMain.bits == "x86")
            {
                nextActorAddress32 = Memory.readUInt32((long) (Memory.readUInt32(Memory.NUJISHIRHOECKHOTHOYGEQ + UNKNOWN_maybe_LocalPlayer.KBYDIZQITHHIDCVJUJGRXT) + 0x5d78));
                while (nextActorAddress32 != 0L)
                {
                    this.addressToActorDB[nextActorAddress32] = new Actor(nextActorAddress32);
                    nextActorAddress32 = Memory.readUInt32(((long) nextActorAddress32) + 0x48L);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Actor this[ulong actorAddress]
        {
            get
            {
                return this.addressToActorDB[actorAddress];
            }
        }
    }
}

