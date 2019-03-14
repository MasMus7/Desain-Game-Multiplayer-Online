[Serializable]
    public struct playerAtt
    {
        public int idPlayer;
        public int[] coorPlayer;
        public int kill;
        public int killed;
        public int assist;
        public float healthPlayer;
        public int shoot;
        public int idTarget;
        public int bomb;
        public string notification;

        public playerAtt(int id, int x, int y, int k, int kd, int ast, float hp, int tembak, int target, int bom, string notif)
        {
            this.idPlayer = id;
            coorPlayer = new int[2];
            coorPlayer[0] = x;
            coorPlayer[1] = y;
            this.kill = k;
            this.killed = kd;
            this.assist = ast;
            healthPlayer = hp;
            this.shoot = tembak;
            this.idTarget = target;
            this.bomb = bom;
            notification = notif;
        }

Pada game CS Go, data yang dikirim adalah
1. id dari player
2. koordinat posisi player
3. status score : jumlah kill, killed, assist
4. Health dari player
5. tembakan
6. id dari target
7. senjata : bomb, efek dari bomb dan senjata
8. notofikasi : notif ketika player membunuh atau terbunuh

Masih belum selesai pak, masih mencoba mengubah struct kedalam byte yang nanti byte tersebut akan saya coba kirimkan. Saya masih mencari cari cara untuk mengirimkannya
