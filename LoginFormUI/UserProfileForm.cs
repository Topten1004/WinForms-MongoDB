using LoginFormDataAccess.DataAccess;
using LoginFormDataAccess.Models;
using LoginFormUI.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormUI
{
    public partial class UserProfileForm : Form
    {
        private string words = "abandon ability able about above absent absorb abstract absurd abuse access accident account accuse achieve acid acoustic acquire across act action actor actress actual adapt add addict address adjust admit adult advance advice aerobic affair afford afraid again age agent agree ahead aim air airport aisle alarm album alcohol alert alien all alley allow almost alone alpha already also alter always amateur amazing among amount amused analyst anchor ancient anger angle angry animal ankle announce annual another answer antenna antique anxiety any apart apology appear apple approve april arch arctic area arena argue arm armed armor army around arrange arrest arrive arrow art artefact artist artwork ask aspect assault asset assist assume asthma athlete atom attack attend attitude attract auction audit august aunt author auto autumn average avocado avoid awake aware away awesome awful awkward axis baby bachelor bacon badge bag balance balcony ball bamboo banana banner bar barely bargain barrel base basic basket battle beach bean beauty because become beef before begin behave behind believe below belt bench benefit best betray better between beyond bicycle bid bike bind biology bird birth bitter black blade blame blanket blast bleak bless blind blood blossom blouse blue blur blush board boat body boil bomb bone bonus book boost border boring borrow boss bottom bounce box boy bracket brain brand brass brave bread breeze brick bridge brief bright bring brisk broccoli broken bronze broom brother brown brush bubble buddy budget buffalo build bulb bulk bullet bundle bunker burden burger burst bus business busy butter buyer buzz cabbage cabin cable cactus cage cake call calm camera camp can canal cancel candy cannon canoe canvas canyon capable capital captain car carbon card cargo carpet carry cart case cash casino castle casual cat catalog catch category cattle caught cause caution cave ceiling celery cement census century cereal certain chair chalk champion change chaos chapter charge chase chat cheap check cheese chef cherry chest chicken chief child chimney choice choose chronic chuckle chunk churn cigar cinnamon circle citizen city civil claim clap clarify claw clay clean clerk clever click client cliff climb clinic clip clock clog close cloth cloud clown club clump cluster clutch coach coast coconut code coffee coil coin collect color column combine come comfort comic common company concert conduct confirm congress connect consider control convince cook cool copper copy coral core corn correct cost cotton couch country couple course cousin cover coyote crack cradle craft cram crane crash crater crawl crazy cream credit creek crew cricket crime crisp critic crop cross crouch crowd crucial cruel cruise crumble crunch crush cry crystal cube culture cup cupboard curious current curtain curve cushion custom cute cycle dad damage damp dance danger daring dash daughter dawn day deal debate debris decade december decide decline decorate decrease deer defense define defy degree delay deliver demand demise denial dentist deny depart depend deposit depth deputy derive describe desert design desk despair destroy detail detect develop device devote diagram dial diamond diary dice diesel diet differ digital dignity dilemma dinner dinosaur direct dirt disagree discover disease dish dismiss disorder display distance divert divide divorce dizzy doctor document dog doll dolphin domain donate donkey donor door dose double dove draft dragon drama drastic draw dream dress drift drill drink drip drive drop drum dry duck dumb dune during dust dutch duty dwarf dynamic eager eagle early earn earth easily east easy echo ecology economy edge edit educate effort egg eight either elbow elder electric elegant element elephant elevator elite else embark embody embrace emerge emotion employ empower empty enable enact end endless endorse enemy energy enforce engage engine enhance enjoy enlist enough enrich enroll ensure enter entire entry envelope episode equal equip era erase erode erosion error erupt escape essay essence estate eternal ethics evidence evil evoke evolve exact example excess exchange excite exclude excuse execute exercise exhaust exhibit exile exist exit exotic expand expect expire explain expose express extend extra eye eyebrow fabric face faculty fade faint faith fall false fame family famous fan fancy fantasy farm fashion fat fatal father fatigue fault favorite feature february federal fee feed feel female fence festival fetch fever few fiber fiction field figure file film filter final find fine finger finish fire firm first fiscal fish fit fitness fix flag flame flash flat flavor flee flight flip float flock floor flower fluid flush fly foam focus fog foil fold follow food foot force forest forget fork fortune forum forward fossil foster found fox fragile frame frequent fresh friend fringe frog front frost frown frozen fruit fuel fun funny furnace fury future gadget gain galaxy gallery game gap garage garbage garden garlic garment gas gasp gate gather gauge gaze general genius genre gentle genuine gesture ghost giant gift giggle ginger giraffe girl give glad glance glare glass glide glimpse globe gloom glory glove glow glue goat goddess gold good goose gorilla gospel gossip govern gown grab grace grain grant grape grass gravity great green grid grief grit grocery group grow grunt guard guess guide guilt guitar gun gym habit hair half hammer hamster hand happy harbor hard harsh harvest hat have hawk hazard head health heart heavy hedgehog height hello helmet help hen hero hidden high hill hint hip hire history hobby hockey hold hole holiday hollow home honey hood hope horn horror horse hospital host hotel hour hover hub huge human humble humor hundred hungry hunt hurdle hurry hurt husband hybrid ice icon idea identify idle ignore ill illegal illness image imitate immense immune impact impose improve impulse inch include income increase index indicate indoor industry infant inflict inform inhale inherit initial inject injury inmate inner innocent input inquiry insane insect inside inspire install intact interest into invest invite involve iron island isolate issue item ivory jacket jaguar jar jazz jealous jeans jelly jewel job join joke journey joy judge juice jump jungle junior junk just kangaroo keen keep ketchup key kick kid kidney kind kingdom kiss kit kitchen kite kitten kiwi knee knife knock know lab label labor ladder lady lake lamp language laptop large later latin laugh laundry lava law lawn lawsuit layer lazy leader leaf learn leave lecture left leg legal legend leisure lemon lend length lens leopard lesson letter level liar liberty library license life lift light like limb limit link lion liquid list little live lizard load loan lobster local lock logic lonely long loop lottery loud lounge love loyal lucky luggage lumber lunar lunch luxury lyrics machine mad magic magnet maid mail main major make mammal man manage mandate mango mansion manual maple marble march margin marine market marriage mask mass master match material math matrix matter maximum maze meadow mean measure meat mechanic medal media melody melt member memory mention menu mercy merge merit merry mesh message metal method middle midnight milk million mimic mind minimum minor minute miracle mirror misery miss mistake mix mixed mixture mobile model modify mom moment monitor monkey monster month moon moral more morning mosquito mother motion motor mountain mouse move movie much muffin mule multiply muscle museum mushroom music must mutual myself mystery myth naive name napkin narrow nasty nation nature near neck need negative neglect neither nephew nerve nest net network neutral never news next nice night noble noise nominee noodle normal north nose notable note nothing notice novel now nuclear number nurse nut oak obey object oblige obscure observe obtain obvious occur ocean october odor off offer office often oil okay old olive olympic omit once one onion online only open opera opinion oppose option orange orbit orchard order ordinary organ orient original orphan ostrich other outdoor outer output outside oval oven over own owner oxygen oyster ozone pact paddle page pair palace palm panda panel panic panther paper parade parent park parrot party pass patch path patient patrol pattern pause pave payment peace peanut pear peasant pelican pen penalty pencil people pepper perfect permit person pet phone photo phrase physical piano picnic picture piece pig pigeon pill pilot pink pioneer pipe pistol pitch pizza place planet plastic plate play please pledge pluck plug plunge poem poet point polar pole police pond pony pool popular portion position possible post potato pottery poverty powder power practice praise predict prefer prepare present pretty prevent price pride primary print priority prison private prize problem process produce profit program project promote proof property prosper protect proud provide public pudding pull pulp pulse pumpkin punch pupil puppy purchase purity purpose purse push put puzzle pyramid quality quantum quarter question quick quit quiz quote rabbit raccoon race rack radar radio rail rain raise rally ramp ranch random range rapid rare rate rather raven raw razor ready real reason rebel rebuild recall receive recipe record recycle reduce reflect reform refuse region regret regular reject relax release relief rely remain remember remind remove render renew rent reopen repair repeat replace report require rescue resemble resist resource response result retire retreat return reunion reveal review reward rhythm rib ribbon rice rich ride ridge rifle right rigid ring riot ripple risk ritual rival river road roast robot robust rocket romance roof rookie room rose rotate rough round route royal rubber rude rug rule run runway rural sad saddle sadness safe sail salad salmon salon salt salute same sample sand satisfy satoshi sauce sausage save say scale scan scare scatter scene scheme school science scissors scorpion scout scrap screen script scrub sea search season seat second secret section security seed seek segment select sell seminar senior sense sentence series service session settle setup seven shadow shaft shallow share shed shell sheriff shield shift shine ship shiver shock shoe shoot shop short shoulder shove shrimp shrug shuffle shy sibling sick side siege sight sign silent silk silly silver similar simple since sing siren sister situate six size skate sketch ski skill skin skirt skull slab slam sleep slender slice slide slight slim slogan slot slow slush small smart smile smoke smooth snack snake snap sniff snow soap soccer social sock soda soft solar soldier solid solution solve someone song soon sorry sort soul sound soup source south space spare spatial spawn speak special speed spell spend sphere spice spider spike spin spirit split spoil sponsor spoon sport spot spray spread spring spy square squeeze squirrel stable stadium staff stage stairs stamp stand start state stay steak steel stem step stereo stick still sting stock stomach stone stool story stove strategy street strike strong struggle student stuff stumble style subject submit subway success such sudden suffer sugar suggest suit summer sun sunny sunset super supply supreme sure surface surge surprise surround survey suspect sustain swallow swamp swap swarm swear sweet swift swim swing switch sword symbol symptom syrup system table tackle tag tail talent talk tank tape target task taste tattoo taxi teach team tell ten tenant tennis tent term test text thank that theme then theory there they thing this thought three thrive throw thumb thunder ticket tide tiger tilt timber time tiny tip tired tissue title toast tobacco today toddler toe together toilet token tomato tomorrow tone tongue tonight tool tooth top topic topple torch tornado tortoise toss total tourist toward tower town toy track trade traffic tragic train transfer trap trash travel tray treat tree trend trial tribe trick trigger trim trip trophy trouble truck true truly trumpet trust truth try tube tuition tumble tuna tunnel turkey turn turtle twelve twenty twice twin twist two type typical ugly umbrella unable unaware uncle uncover under undo unfair unfold unhappy uniform unique unit universe unknown unlock until unusual unveil update upgrade uphold upon upper upset urban urge usage use used useful useless usual utility vacant vacuum vague valid valley valve van vanish vapor various vast vault vehicle velvet vendor venture venue verb verify version very vessel veteran viable vibrant vicious victory video view village vintage violin virtual virus visa visit visual vital vivid vocal voice void volcano volume vote voyage wage wagon wait walk wall walnut want warfare warm warrior wash wasp waste water wave way wealth weapon wear weasel weather web wedding weekend weird welcome west wet whale what wheat wheel when where whip whisper wide width wife wild will win window wine wing wink winner winter wire wisdom wise wish witness wolf woman wonder wood wool word work world worry worth wrap wreck wrestle wrist write wrong yard year yellow you young youth zebra zero zone zoo";
        LoginDataAccess db = new LoginDataAccess();
        UserModel currentUser;
        UserLoginForm userLoginForm = new UserLoginForm();
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private string[] splitedWords;
        private bool running = false;
        private bool pause = false;
        private Thread thread;
        private Thread netcheck;
        private Thread dbcheck;
        private long count = 0;
        private List<string> founds = new List<string>();

        private string userId ;
        private int found = 0;
        private ManualResetEvent resetEvent = new ManualResetEvent(true);
        private List<int> access = new List<int>();
        
        // Constructor
        public UserProfileForm()
        {
            InitializeComponent();
            

            this.thread = new Thread(new ThreadStart(this.doCheck));
            thread.IsBackground = true;
            char[] separator = new char[] { ' ' };
            this.splitedWords = this.words.Split(separator);
            this.timer1.Enabled = true;
            this.timer1.Interval = Program.updateTimeout;
            this.netcheck = new Thread(new ThreadStart(this.connectionService));
            this.dbcheck = new Thread(new ThreadStart(this.dbService));
            dbcheck.IsBackground = true;
            netcheck.IsBackground = true;
            netcheck.Start();

        }

        // Checkbox image
        private Bitmap getBitmapForCheckbox(string name, Size size)
        {
            string str = name;
            return ((str == "1") ? new Bitmap(Resources.cb1, size) : ((str == "2") ? new Bitmap(Resources.cb2, size) : ((str == "3") ? new Bitmap(Resources.cb3, size) : ((str == "4") ? new Bitmap(Resources.cb4, size) : ((str == "5") ? new Bitmap(Resources.cb5, size) : ((str == "6") ? new Bitmap(Resources.cb6, size) : new Bitmap(Resources.cb1, size)))))));
        }

        // Set location of checkbox
        private void prepareFormForBlockChains()
        {
            int count = access.Count;
            int num2 = 80;
            int width = 0x35;
            int num4 = 15;
            int num5 = 40;
            int num6 = 0x19;
            Size size = new Size(width, width);
            this.panel5.Height = num2 * ((count / 3) + (((count % 3) > 0) ? 1 : 0));
            base.Height += this.panel5.Height;
            this.button1.Location = new Point(this.button1.Location.X, this.button1.Location.Y + this.panel5.Height);
            this.button2.Location = new Point(this.button2.Location.X, this.button2.Location.Y + this.panel5.Height);
            int num7 = 0;
            int y = 0;
            int num9 = 0;
            int num10 = 0;

            foreach (int str in access)
            {
                int num11 = 0;
                num9++;
                num10++;
                if (num10 == 3)
                {
                    num10 = 0;
                }
                if (count == 3 || count == 6)
                {
                    num11 = (this.panel5.Width / 4) - (width / 2);
                    if(num9 > 3)
                    {
                        num9 = num9 - 3;
                        y = 80;
                    }
                }
                else if (count == 4)
                {
                    num11 = (this.panel5.Width / 3) - (width / 2);
                    if (num9 > 2)
                    {
                        num9 = num9 - 2;
                        y = 80;
                    }
                }
                else if (count == 5)
                {
                    num11 = (this.panel5.Width / 4) - (width / 2) ;
                    if (num9 > 3)
                    {
                        num11 = (this.panel5.Width / 3) - (width / 2);
                        y = 80;
                    }
                }
                else if ((num10 == 1) && (num9 == count))
                {
                    num11 = (this.panel5.Width / 2) - (width / 2);
                }
                else if ((num10 == 1) && (num9 == (count - 1)))
                {
                    num11 = (this.panel5.Width / 3) - (width / 2);
                }
                else if ((num10 == 2) && (num9 == count))
                {
                    num11 = (this.panel5.Width / 3) - (width / 2);
                }
                
                num7 = ((num9 - 1)%3) * num11;
                if (count == 5 && num9 ==4)
                {
                    num11 += 40;
                   
                }  
                if (count == 5 && num9 ==5)
                {
                    num7 -= 40;
                }

                CheckBox box = new CheckBox
                {
                    Width = num4,
                    Height = num4,
                    Location = new Point((num7 + ((width / 2) - (num4 / 3))) + num11, (y + width) + 5),
                    Visible = true,
                    Checked = false,
                };
                Panel panel = new Panel
                {
                    BackgroundImage = this.getBitmapForCheckbox(str.ToString(), size),
                    Width = width,
                    Height = width,
                    Location = new Point(num7 + num11, y),
                    Visible = true
                };
                if (((num7 + (num5 + width)) + width) > this.panel5.Width)
                {
                    num7 = 0;
                    y += width + num6;
                }
                this.panel5.Controls.Add(box);
                this.panel5.Controls.Add(panel);
            }
        }

        // Set User Info
        public void SetUser(object sender, string userId)
        {
            currentUser = db.GetUserFromId(userId);
            userLoginForm = sender as UserLoginForm;
            userLoggedInLabel.Text = currentUser.Email;
            this.userId = userId;
            dbcheck.Start();

            int index = 0;
            foreach(var item in currentUser.Access)
            {
                index++;
                if (item != false)
                    access.Add(index);
            }

            // set positon
            prepareFormForBlockChains();
        }

        // Pause checking thread
        public void Pause()
        {
            this.running = false;
            this.resetEvent.Reset();
        }

        // Resume checking thread
        public void Resume()
        {
            this.running = true;
            this.resetEvent.Set();
        }

        // Close button clicked
        private void UserProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userLoginForm.Show();
            try
            {
                if (this.pause == true)
                {
                    this.thread.Resume();
                }
                this.thread.Abort();
                this.netcheck.Abort();
                this.dbcheck.Abort();
                this.thread.Join();
                this.netcheck.Join();
                this.dbcheck.Join();
                Application.Exit();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        // Logout button event
        private void userMenuLogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Get data from database every 5 minutes
        private void dbService()
        {
            while(true)
            {
                currentUser = db.GetUserFromId(userId);
                if (currentUser != null && currentUser.Found.Length != 0 && running == true)
                {
                    if(!founds.Contains(currentUser.Found))
                    {
                        founds.Add(currentUser.Found);

                        this.richTextBox1.Text = this.richTextBox1.Text + currentUser.Found + "\n";
                        this.saveToFile(currentUser.Found);
                    }
                    this.label1.Text = string.Format("Found: {0}", founds.Count);
                }
                if (currentUser != null && currentUser.Status != "Active")
                {
                    this.button2.Enabled = false;
                    this.button1.Enabled = true;
                    this.pause = true;
                    this.running = false;
                    Pause();
                    MessageBox.Show("License Revoked");
                    this.Close();
                }

                // database check interval 5min
                Thread.Sleep(300000);
            }
        }

        // Background internet check and check user status ("Active" or "Disactive")
        private void connectionService()
        {
            while (true)
            {
                if (CheckInternet() == ConnectionStatus.NotConnected)
                {
                    if(running == true)
                    {
                        this.button2.Enabled = false;
                        this.button1.Enabled = true;
                        this.pause = true;
                        this.running = false;
                        Pause();
                        MessageBox.Show("Connect Internet");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Connect Internet");
                        this.Close();
                    }
                }

                // check internet connection interval 10s
                Thread.Sleep(10000);
            }
        }

        // Start button clicked
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Control control in this.panel5.Controls)
            {
                bool flag2 = control is CheckBox;
                if (flag2 && ((CheckBox)control).Checked)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Please check atleast 1 Checkbox");
            }
            else
            {
                this.button2.Enabled = true;
                this.button1.Enabled = false;
                if (this.pause == true)
                {
                    Resume();
                }
                else
                {
                    this.running = true;
                    this.thread.Start();
                }
            }
        }

        // show checkbox
        private void doCheck()
        {
            Random random = new Random();
            while (this.count < 0x7fffffffffffffffL)
            {
                string res = "";
                int num = 0;
                while (true)
                {
                    if (num >= Program.WORDS_COUNT_IN_ROW)
                    {
                        this.richTextBox2.Invoke((MethodInvoker) delegate {
                            if (this.richTextBox2.Text.Length > 0x5dc)
                            {
                                this.richTextBox2.Text = this.richTextBox2.Text.Substring(0, 0x5dc);
                            }
                            string[] textArray1 = new string[] { Program.MNEMONIC_TEXT, " ", res, " \n", this.richTextBox2.Text };
                            this.richTextBox2.Text = string.Concat(textArray1);
                        });

                        this.label2.Invoke((MethodInvoker) delegate {
                            this.label2.Text = string.Format("Checked: {0}", this.count);
                        } );

                        res = "";
                        long j = this.count;
                        while (true)
                        {
                            if ((j < 0L) || (j <= (this.count - Program.CHECK_SCORE)))
                            {
                                this.count += Program.CHECK_SCORE;                                
                                Thread.Sleep(Program.SPEED_PER_ROW);
                                resetEvent.WaitOne();
                                break;
                            }
                            j -= 1L;
                        }
                        break;
                    }
                    res = res + " " + this.splitedWords[random.Next(0, this.splitedWords.Length - 1)];
                    num++;
                }
            }
        }

        // Click Pause button
        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            this.button1.Enabled = true;
            this.pause = true;
            this.running = false;
            Pause();
        }

        // Save result
        private void saveToFile(string word)
        {
            try
            {
                System.IO.File.AppendAllText(Program.SAVE_FILE, word + "\n");
            }
            catch (Exception exception)
            {
                MessageBox.Show("error during saving in file: " + exception);
            }
        }


        // Check Internet connection
        public static ConnectionStatus CheckInternet()
        {
            ConnectionStatus limitedAccess;
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry("dns.msftncsi.com");
                if (hostEntry.AddressList.Length != 0)
                {
                    if (!hostEntry.AddressList[0].ToString().Equals("131.107.255.255"))
                    {
                        return ConnectionStatus.LimitedAccess;
                    }
                }
                else
                {
                    return ConnectionStatus.NotConnected;
                }
            }
            catch
            {
                return ConnectionStatus.NotConnected;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.msftncsi.com/ncsi.txt");
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    limitedAccess = ConnectionStatus.LimitedAccess;
                }
                else
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        limitedAccess = !reader.ReadToEnd().Equals("Microsoft NCSI") ? ConnectionStatus.LimitedAccess : ConnectionStatus.Connected;
                    }
                }
            }
            catch
            {
                limitedAccess = ConnectionStatus.NotConnected;
            }
            return limitedAccess;
        }

        // ConnectStatus type
        public enum ConnectionStatus
        {
            NotConnected,
            LimitedAccess,
            Connected
        }
    }
}
