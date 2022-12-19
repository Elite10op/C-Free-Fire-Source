 public static bool IsAlreadyRunning = false;

        private static Mem Memory = new Mem();



        #region
        public async void Rep(string scan, string rep)
        {
            IsAlreadyRunning = true;
            if (!Memory.OpenProcess("HD-Player.exe"))
            {
                ZER.Text = "Corre o teu jogo primeiro!";
                ZER.ForeColor = Color.Red;
                return;
            }
            ZER.Text = "Aplicando...";
            ZER.ForeColor = Color.Blue;

            IEnumerable<long> source = await Memory.AoBScan(0L, 2533274790395904L, scan, writable: true);
            if (source.Count() != 0)
            {
                for (int i = 0; i < source.Count(); i++)
                {


                    Memory.WriteMemory(source.ElementAt(i).ToString("X"), "bytes", rep);

                }
                ZER.Text = "Aplicado Succeso";
                ZER.ForeColor = Color.Green;
                await Task.Delay(2000);

            }
            else
            {
                ZER.Text = "Aplicando Error";
                ZER.ForeColor = Color.Red;

            }
            Memory.CloseProcess();
            IsAlreadyRunning = false;
        }
        public async void Rep1(string scan, string rep)
        {
            IsAlreadyRunning = true;
            if (!Memory.OpenProcess("AndroidProcess"))
            {
                ZER.Text = "Run your game first!";
                ZER.ForeColor = Color.Red;
                return;
            }
            ZER.Text = "Aplicando......";
            ZER.ForeColor = Color.Blue;

            IEnumerable<long> source = await Memory.AoBScan(0L, 2533274790395904L, scan, writable: true);
            if (source.Count() != 0)
            {
                for (int i = 0; i < source.Count(); i++)
                {


                    Memory.WriteMemory(source.ElementAt(i).ToString("X"), "bytes", rep);

                }
                ZER.Text = "Aplicado Succeso";
                ZER.ForeColor = Color.Green;
                await Task.Delay(2000);

            }
            else
            {
                ZER.Text = "Aplicando Error!";
                ZER.ForeColor = Color.Red;

            }
            Memory.CloseProcess();
            IsAlreadyRunning = false;
        }
        public async void Rep2(string scan, string rep)
        {
            IsAlreadyRunning = true;
            if (!Memory.OpenProcess("aow_exe"))
            {
                ZER.Text = "Corre o teu jogo primeiro!";
                ZER.ForeColor = Color.Red;
                return;
            }
            ZER.Text = "Aplicando......";
            ZER.ForeColor = Color.Blue;

            IEnumerable<long> source = await Memory.AoBScan(0L, 2533274790395904L, scan, writable: true);
            if (source.Count() != 0)
            {
                for (int i = 0; i < source.Count(); i++)
                {


                    Memory.WriteMemory(source.ElementAt(i).ToString("X"), "bytes", rep);

                }
                ZER.Text = "Aplicado Succeso";
                ZER.ForeColor = Color.Green;
                await Task.Delay(2000);

            }
            else
            {
                ZER.Text = "Aplicado Error!";
                ZER.ForeColor = Color.Red;

            }
            Memory.CloseProcess();
            IsAlreadyRunning = false;
        }
        public async void Rep3(string scan, string rep)
        {
            IsAlreadyRunning = true;
            if (!Memory.OpenProcess("LdVBoxHeadless"))
            {
                ZER.Text = "Corre o teu jogo primeiro!";
                ZER.ForeColor = Color.Red;
                return;
            }
            ZER.Text = "Aplicando...";
            ZER.ForeColor = Color.Blue;

            IEnumerable<long> source = await Memory.AoBScan(0L, 2533274790395904L, scan, writable: true);
            if (source.Count() != 0)
            {
                for (int i = 0; i < source.Count(); i++)
                {


                    Memory.WriteMemory(source.ElementAt(i).ToString("X"), "bytes", rep);

                }
                ZER.Text = "Aplicado Succeso...";
                ZER.ForeColor = Color.Green;
                await Task.Delay(2000);

            }
            else
            {
                ZER.Text = "Aplicado Error!";
                ZER.ForeColor = Color.Red;

            }
            Memory.CloseProcess();
            IsAlreadyRunning = false;
        }
        public async void Rep4(string scan, string rep)
        {
            IsAlreadyRunning = true;
            if (!Memory.OpenProcess("MEmuHeadless"))
            {
                ZER.Text = "Corre o teu jogo primeiro!";
                ZER.ForeColor = Color.Red;
                return;
            }
            ZER.Text = "Aplicando...";
            ZER.ForeColor = Color.Blue;

            IEnumerable<long> source = await Memory.AoBScan(0L, 2533274790395904L, scan, writable: true);
            if (source.Count() != 0)
            {
                for (int i = 0; i < source.Count(); i++)
                {


                    Memory.WriteMemory(source.ElementAt(i).ToString("X"), "bytes", rep);

                }
                ZER.Text = "Aplicado Enabled";
                ZER.ForeColor = Color.Green;
                await Task.Delay(2000);

            }
            else
            {
                ZER.Text = "Aplicando Error!";
                ZER.ForeColor = Color.Red;

            }
            Memory.CloseProcess();
            IsAlreadyRunning = false;
        }

        #endregion
