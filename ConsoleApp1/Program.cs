using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static IEnumerable<T[]> GetCombinations<T>(T[] source)
        {
            for (var i = 0; i < (1 << source.Length); i++)
                yield return source
                   .Where((t, j) => (i & (1 << j)) != 0)
                   .ToArray();
        }

        public static IEnumerable<int[]> GetItems(IEnumerable<int> source, int target)
               => GetCombinations(source.ToArray())
                  .Where(items => items.Sum() == target);
        static void Main(string[] args)
        {

            //var jumlahKeluarga = Console.ReadLine();
            int falg = 0;

            //int[] anggota = new int[Convert.ToInt32(jumlahKeluarga)];
            //string[] suit = new string[Convert.ToInt32(jumlahKeluarga)];


            int[] raindears = new int[] { };
            List<int> example = new List<int>();

            //for (int a = 0; a < Convert.ToInt32(jumlahKeluarga); a++)
            //{
            //    string inputed = Console.ReadLine();
            //    //anggota[a] = Convert.ToInt32((inputed).ToString());
            //    suit[a] = inputed;
            //    falg++;
            //}

            string textTest = "srjsssgppnssqzszmzjmjdmmqwqcwqccslsjswjssgbsgsnggqtqnnjznndtndnhddfldfdsfswsjsjjptjpttlwlccpnpgngcncnscncsnnwrwmwggsgdgssvbsstzsstqqrjqqlsqlsqscschhclhccznzcnnzzqppjbpjjqzzbwbqqzdqdjjqtjtbtgtqgtgdgwwsjjbwjjzssrsvsttgqtgglgplgpllcrcncssbrbgrbrllsqlsltthshrrnddwzdzdbbrppdvdqvvpvdvdsslbbmnbnjjrdrnntzzftzftttrsshpspvvrzzqzwzhzszbzjjwqwvqqglgflfwfrfprpddfvdffhzztwtppwwwztzsznzmnnbvbbtqqdhqdqdfffnjnmnlmljmlmnlnddzbbdgdqdnqqtjjtnthttvwwtrwwwgffqcfchfcfwcczhhgjhghpgpwgwffhghzghhtftntnnmlnmlmddqbbfwbfwbwvvfssrggptpltpllbcbzczzlccjgcgvcczjzvvvdtvdvqdqwdqdvdjvddjfdjjqmmfgfsftfzfwzwzfftmfmmqdqccjqcqwwflwlccpssvzzzbnbjnbjjgtgpttbwbrbwrwvrrwccgrgrvvpjvvznvvhddtdldpldppmlplltdllhqhpqhqqbpptgpgjgqjgjffvfdvdttsrsllhzlzrrdrnrjrddqbbjrrvrsstgsttjqjhjbhhnmndmmnrmnnrggmtgmmhshjjfqjjtqtstpstppggtzzrsrwwqffvzvzvqqggqsqtstszttpvtvvvddcncvncvchhnsnpsnnlmnnmqnqjjfwfccmwmbwbswbswwghhzrrptptbbjbtjjgdjgjrgrwgwlglblbnlnbbwnnpbnbmbtmtvvhjjlwlhhszslldwlwdllhjhghqghhqpplhhtjhhnhqhlhjhmmlhlmmrpptvvcczfcccwgcccpgpspdpccfhchffbjbzzwppfbbstbtltpllcssnnctnnqcqhhclhccvlvlffnjjwbwfbfttwvvdvnnnsrstrtmtfthtzzcvzvhzzpmpfpmmmwggdbdqdbbjnbbdqbbrnnnprrwbbcwbbpjjprjjzzvwwvrrthhqvhvnhhzmzszrszsjssclcjjbhjbhjbhjbjhhzbbzttnrnssrbrjbrjjmsmffdlflfzfbzzmtztdthdhldhlddnccgbbmtbbsbzsbzzcsszpzfffprfpfzfrzzhvhffsmmqtjwgjbzhnmrslrmgfjpqcllcgsjdhrshqtlgmqqtfmswfzwtnrswtzdjzclcfmltqgdhcsgvzrdltgfbtqclpppvbqnbqmlhmdbsjbwbdllzpnrwfhmnlgvdwsdjsznnhqzhwntjvcpzdrfwmwwdrttdvzspmbmqggmlmsvwgcjgpvcmplqwfjgpghnfpbctnfhcgngcbdmzhlpcnjpmczzsgfgrdftrzgvmmpdmgcrpcdrjsgczpfjnwpdjpntdngdjwctvcbsjmfwvtsrlhvpswppmfwrwzsbsgbjvljzqjjldmnqnmwsmqnmhmqhhttppbpqlvdcvdbhmbnjzztjrdjdzlvmbdrghtftwdpcwwblsjbgnzwtpztmtmnrpsvzfzncqmrvhcbqcvqvnlngdcllrqlbhjttnmjmhfhdzmjmplcfdqpmwblzsnmpczwcnggcwdvgnjcrrtmpwwqdqpvtbzpdbfnbfcfllntqjlslcsznjvzvsbntrtzwhcbtdmbmwttvhdvdtvrcmprcrrjlgsqddrsmwsrbtbpjrmlbrnsdrjfhjnqjtgjmhzjbjnprvmhtjcdbztwqmrlfflfmcslshtwmwhgvbdslgjhzjlglhllsdphlzngjfwfrlwpnqfhghnqhzhgrszbcwjvlrtmshntszsqplvfbccjwctgtfmqgqjdlgdbwhgvctqtcgfdwvqdwqzddmsbrpftzpqztgzbnplvhftmgpdthnrdhqbltbrmhpcqsfccmqzwmrbnbgbjspslwpjhdqspssqdtnssmjmvzwwfstgzzjrmfczdlznwqpdhbsjqddvffcgfhfdqdrlwcsgcsszdtpqbbsthpwbhdfzmgmcdggfcwcmzfjnfbzbccjhvwhbwfslnqnrwhgrwtlnmrmncnjtbjbdlmqsczppgbcmsdrwlrpjbgrmnhqqfhhsdhmdmpvvpjrnzsvzctmqhpzcvcjfgtlfvqvnvlnprmgrsvrrvtjfndqfsvqdsfbcwlbglmfhfhcfgqdfmclnzhdtppgzzsqgjqncqrbdhlhdjqwjpmbdnfmgdgwbwmnlngnmrhcgqwzvmbjzdvsspjwwdtpnvpftdlqlzfgtscfczsvbrtrqqpgqlvmrtddqplbzsswbgpdzpqfvqpqbndblghmdhmnctdnjbgglmrlvmrmsfgntfdwvqcvvlvbcnwrctvjqhmnsjqccwltbfqpqpmwsfvmnnfqmlmlcchqcdtbvqwcpptvfwrwtbdrlsgnwpmjgnwlprzqjlwqmtmjglbrzlgfbsghwqdmwhrcmfwdmzmflsbngtgndftdpzsqvgqdsfdhplmfcmwpbtvcdmpghmfwqjvhdhfpmbrqpvnbhlftgdtprlztrgnlcldfpjqjqdfrvqtcnzrtjcgzgsslzghlnfhwwjwzdsmpsczclrfmnqjvfmvsqpntsnnnlrfswqtrppzhqgjzlzvrrbhhfhchhvgztpgctcsgssvttszsrdwzwrbmwmspgqhmmfnzqqdbmnbltdmrsvqgddltwczbbjcmplncspgqgmzrndhttsrbvqbpbvhshfqrpqgmmdbhmmtccjcmntmpqhrvhnfnlqqbctsnfzjbphhqwmztgbhqqlbctbsfcszbggzrlcdhwddtjgtqhppzgjsqcddwjsngjrcdflmgwgfnzhjtcwgbqvpwmpgcpdwvqgswwfzcnjgmdpffmqczmsqgpthpmsjlwnrcbzrfshvwftzllwrmfccmlpjnmpjdfpcvjgjpznllmqjwpcflgqgdljtbbjvjlvhhmtvzfnjfnnwrvtlfdbhqphrjghtmlsrplqscsnvjvqdslsbsfzzrjfmchplzgjgdqvzhfphvsjfvnqlgmjfzhrdlmmvfntnzdvrnwqshsmtjnqmwzgpbbzszrsqcvlzjwnmgjhmfqrbvgmfqpswctmvpfcghvdqgstglmzvpfhzfzvhqqdmvrvrttlpwwhqgddzqlrvvdffqtznvlfgjhhmvbmtzjqnnhqzrtbzpqcwpngrdcndcgzwhzgtfwbmwbrpvvczczhwcqwsqzqbqvqftcswtcbzdbpccjhtwbpnwlwwwqwscptlwshrdbmmdcgrmpnnwgjwzszwwdwctfspbfqvdjqtrflshrqlbfgpnrmbszwjpcdzbggphgplcgvwljprzmtncsvfwqchttndhpnzmtdvtjqtcsddtqvcmztmjgwqvjhflrjjtnvfpjrnlvzvwvrpbhrzslmrqqzqhnzqnvtqppmncddphbwwsjczmphsrlltzndtqjgdlqgpnlfcvwntstmrgcrjzmmllpwldnwmwzpvzctmhszspcvtgnqthszzsmtdnzwtfddfctpjhscbqgwfpqmzpvqrzvtbrdjzrqprdgbpmzzfbgqcvcdtsfrffcpqwtvdwvtcqlcsdrzntgrhrspznndslmnvptlphpdqgbblfhmgbpmmfwqzlhvzshhpzgfjldqclngbcbrmmnqqvqmwdnjsglsggqfgjldqfbsqgtrwmpdffqlcwwlfhlpqfgwtssnjwzhgvtwqzmhmgwzwmcggmpmrzqrcsmflqsrbnzvdmjcdbnscstqrqhvddsbjpzwsvzswqhcqmgzlvfcnzjrrffzphmrvdbhqbrwpsfqvfqwhqhcgfvfsfttzcdsrjgjwcgvhllszmplmvgczqsbfldnbvrnqccbprjjdwhmqpdjjrnfdlhzdvlfmrldjlqclbjrrtjfsflphzdcdpfpr";

            // day 6

            //m j q jpqM gbljsphdztnvjfqwrcgsmlb-- > 7

            //b vwbJ plbgvbhsrlpgdmjqwftvncz-- > 5

            //n p pdvJ thqldpwncqszvftbrmjlhg --> 6

            //n z n rnffntJfmvfwmzdfjlvtqnbhcprsg --> 10

            //z c f z f w z zqfr ljwzlrfnpqdbhtmscgvjw-- > 11


            int initialChar = 14;
            int leng = textTest.Length;
            int initialText = 0;

            for(int start= initialChar -1; start < leng; start++)
            {
                string tmpWords = textTest.Substring(initialText, initialChar);
                int check = 0;

                foreach (char charInChoose in tmpWords)
                {
                    int testamal = tmpWords.ToCharArray().Count(c => c == charInChoose);
                    if (testamal > 1)
                    {
                        check++;
                    }

                }

                if (check == 0)
                {
                    Console.WriteLine(tmpWords);
                    Console.WriteLine(start+1);
                    check = 0;
                }

                initialText += 1;
            }


            string[] moveStack = new string[] {"3, 6, 2 ",
            "5, 6, 7 ",
            "6, 2, 5 ",
            "1, 9, 7 ",
            "1, 1, 9 ",
            "1, 5, 3 ",
            "1, 2, 5 ",
            "3, 4, 5 ",
            "10, 7, 3 ",
            "1, 4, 9 ",
            "6, 8, 7 ",
            "4, 7, 8 ",
            "1, 7, 3 ",
            "1, 1, 2 ",
            "1, 2, 8 ",
            "1, 9, 1 ",
            "3, 9, 4 ",
            "4, 8, 3 ",
            "4, 7, 1 ",
            "4, 4, 6 ",
            "2, 8, 7 ",
            "9, 3, 8 ",
            "2, 7, 4 ",
            "3, 4, 9 ",
            "4, 1, 9 ",
            "4, 3, 9 ",
            "2, 1, 4 ",
            "1, 4, 6 ",
            "3, 3, 2 ",
            "1, 2, 8 ",
            "1, 2, 7 ",
            "3, 6, 2 ",
            "2, 6, 7 ",
            "4, 2, 3 ",
            "3, 7, 9 ",
            "2, 5, 6 ",
            "15, 9, 4 ",
            "4, 9, 2 ",
            "12, 5, 4 ",
            "9, 8, 5 ",
            "25, 4, 7 ",
            "1, 4, 7 ",
            "1, 4, 8 ",
            "2, 2, 5 ",
            "1, 4, 2 ",
            "23, 7, 6 ",
            "2, 5, 2 ",
            "22, 6, 8 ",
            "4, 5, 9 ",
            "1, 7, 9 ",
            "2, 6, 4 ",
            "2, 4, 7 ",
            "25, 8, 3 ",
            "1, 2, 1 ",
            "3, 2, 3 ",
            "1, 6, 8 ",
            "1, 1, 8 ",
            "1, 2, 8 ",
            "1, 8, 1 ",
            "4, 5, 7 ",
            "1, 8, 4 ",
            "5, 9, 8 ",
            "5, 8, 9 ",
            "1, 8, 5 ",
            "3, 5, 4 ",
            "3, 9, 1 ",
            "30, 3, 4 ",
            "3, 1, 4 ",
            "2, 9, 5 ",
            "4, 7, 9 ",
            "16, 4, 8 ",
            "6, 3, 9 ",
            "3, 7, 3 ",
            "19, 4, 7 ",
            "8, 9, 4 ",
            "1, 1, 9 ",
            "13, 7, 9 ",
            "3, 7, 8 ",
            "3, 5, 9 ",
            "4, 8, 3 ",
            "2, 7, 3 ",
            "14, 9, 4 ",
            "10, 3, 1 ",
            "12, 4, 8 ",
            "6, 1, 9 ",
            "1, 1, 2 ",
            "1, 7, 1 ",
            "6, 9, 3 ",
            "17, 8, 6 ",
            "10, 8, 5 ",
            "1, 7, 8 ",
            "1, 9, 5 ",
            "2, 3, 1 ",
            "4, 5, 9 ",
            "1, 8, 7 ",
            "6, 9, 7 ",
            "4, 4, 2 ",
            "3, 4, 6 ",
            "4, 5, 9 ",
            "4, 9, 3 ",
            "1, 2, 4 ",
            "4, 4, 7 ",
            "3, 5, 3 ",
            "1, 4, 5 ",
            "5, 1, 2 ",
            "1, 1, 9 ",
            "7, 2, 7 ",
            "1, 5, 7 ",
            "8, 3, 5 ",
            "20, 6, 7 ",
            "9, 7, 9 ",
            "2, 2, 9 ",
            "2, 3, 1 ",
            "2, 1, 3 ",
            "2, 3, 4 ",
            "2, 4, 6 ",
            "1, 3, 9 ",
            "1, 4, 9 ",
            "1, 6, 9 ",
            "2, 5, 8 ",
            "2, 8, 5 ",
            "1, 6, 7 ",
            "2, 5, 8 ",
            "6, 9, 5 ",
            "2, 8, 6 ",
            "11, 9, 2 ",
            "1, 6, 5 ",
            "11, 2, 5 ",
            "1, 6, 4 ",
            "7, 5, 9 ",
            "7, 9, 1 ",
            "1, 4, 9 ",
            "28, 7, 5 ",
            "1, 7, 5 ",
            "5, 5, 9 ",
            "5, 9, 3 ",
            "6, 1, 8 ",
            "1, 1, 7 ",
            "5, 3, 2 ",
            "1, 7, 8 ",
            "7, 8, 1 ",
            "1, 9, 4 ",
            "2, 2, 5 ",
            "22, 5, 3 ",
            "1, 7, 8 ",
            "1, 4, 7 ",
            "1, 8, 9 ",
            "1, 9, 4 ",
            "14, 5, 7 ",
            "5, 5, 9 ",
            "19, 3, 4 ",
            "1, 2, 9 ",
            "2, 2, 5 ",
            "1, 5, 1 ",
            "6, 1, 7 ",
            "2, 7, 6 ",
            "1, 1, 9 ",
            "2, 5, 8 ",
            "8, 4, 5 ",
            "3, 4, 7 ",
            "3, 3, 5 ",
            "2, 8, 9 ",
            "16, 7, 5 ",
            "9, 4, 6 ",
            "22, 5, 3 ",
            "1, 5, 8 ",
            "1, 8, 7 ",
            "10, 3, 4 ",
            "1, 5, 4 ",
            "10, 4, 5 ",
            "8, 5, 2 ",
            "5, 2, 7 ",
            "5, 7, 1 ",
            "4, 7, 6 ",
            "3, 9, 7 ",
            "2, 2, 3 ",
            "3, 5, 1 ",
            "6, 9, 7 ",
            "5, 7, 8 ",
            "6, 1, 5 ",
            "6, 3, 4 ",
            "4, 4, 2 ",
            "1, 4, 6 ",
            "5, 8, 7 ",
            "3, 2, 3 ",
            "1, 1, 4 ",
            "1, 1, 9 ",
            "2, 2, 1 ",
            "2, 4, 3 ",
            "4, 3, 7 ",
            "3, 7, 3 ",
            "13, 6, 1 ",
            "1, 9, 2 ",
            "6, 3, 5 ",
            "8, 1, 4 ",
            "1, 2, 7 ",
            "9, 4, 9 ",
            "7, 5, 1 ",
            "2, 5, 6 ",
            "1, 1, 4 ",
            "1, 4, 3 ",
            "2, 1, 2 ",
            "5, 3, 6 ",
            "2, 6, 1 ",
            "13, 7, 6 ",
            "2, 3, 4 ",
            "2, 2, 9 ",
            "2, 7, 8 ",
            "6, 9, 2 ",
            "1, 9, 3 ",
            "1, 5, 2 ",
            "7, 1, 2 ",
            "1, 6, 7 ",
            "1, 4, 8 ",
            "1, 3, 1 ",
            "1, 7, 8 ",
            "7, 1, 9 ",
            "4, 8, 6 ",
            "1, 5, 3 ",
            "9, 9, 5 ",
            "1, 1, 2 ",
            "14, 2, 7 ",
            "2, 9, 3 ",
            "13, 5, 3 ",
            "24, 6, 9 ",
            "6, 3, 5 ",
            "14, 7, 9 ",
            "1, 4, 1 ",
            "20, 9, 7 ",
            "9, 3, 8 ",
            "15, 9, 6 ",
            "1, 5, 8 ",
            "1, 2, 3 ",
            "14, 6, 3 ",
            "2, 3, 4 ",
            "2, 3, 6 ",
            "13, 7, 1 ",
            "8, 3, 5 ",
            "1, 3, 9 ",
            "8, 5, 4 ",
            "4, 5, 2 ",
            "10, 1, 3 ",
            "6, 4, 5 ",
            "4, 5, 1 ",
            "3, 1, 6 ",
            "7, 8, 2 ",
            "4, 4, 3 ",
            "13, 3, 6 ",
            "3, 8, 1 ",
            "3, 7, 8 ",
            "3, 8, 4 ",
            "1, 4, 2 ",
            "2, 3, 4 ",
            "1, 5, 7 ",
            "4, 7, 1 ",
            "2, 3, 5 ",
            "3, 2, 1 ",
            "1, 4, 7 ",
            "7, 2, 4 ",
            "2, 4, 3 ",
            "1, 7, 5 ",
            "4, 9, 5 ",
            "1, 4, 2 ",
            "3, 2, 9 ",
            "8, 1, 7 ",
            "1, 3, 5 ",
            "7, 5, 7 ",
            "10, 6, 4 ",
            "1, 5, 1 ",
            "4, 1, 3 ",
            "9, 7, 6 ",
            "3, 1, 8 ",
            "12, 4, 6 ",
            "5, 4, 6 ",
            "2, 9, 3 ",
            "3, 8, 7 ",
            "1, 1, 3 ",
            "3, 7, 8 ",
            "5, 7, 5 ",
            "1, 7, 5 ",
            "2, 3, 1 ",
            "2, 8, 7 ",
            "3, 5, 1 ",
            "1, 9, 7 ",
            "1, 8, 3 ",
            "4, 7, 8 ",
            "4, 5, 9 ",
            "4, 1, 7 ",
            "3, 8, 6 ",
            "1, 8, 1 ",
            "1, 7, 1 ",
            "1, 5, 8 ",
            "1, 8, 7 ",
            "7, 3, 1 ",
            "3, 9, 1 ",
            "1, 9, 3 ",
            "28, 6, 3 ",
            "3, 7, 8 ",
            "2, 8, 2 ",
            "1, 2, 7 ",
            "2, 6, 1 ",
            "18, 3, 9 ",
            "5, 3, 4 ",
            "2, 7, 4 ",
            "2, 1, 8 ",
            "1, 2, 6 ",
            "7, 6, 4 ",
            "4, 4, 3 ",
            "3, 8, 1 ",
            "4, 9, 8 ",
            "1, 4, 8 ",
            "9, 1, 6 ",
            "5, 1, 3 ",
            "4, 6, 7 ",
            "7, 6, 3 ",
            "5, 8, 1 ",
            "12, 3, 6 ",
            "7, 6, 4 ",
            "4, 3, 5 ",
            "5, 6, 7 ",
            "12, 4, 3 ",
            "6, 1, 4 ",
            "4, 4, 2 ",
            "14, 9, 8 ",
            "17, 3, 2 ",
            "5, 4, 9 ",
            "1, 9, 6 ",
            "5, 2, 1 ",
            "1, 9, 8 ",
            "5, 1, 6 ",
            "2, 2, 6 ",
            "12, 2, 4 ",
            "6, 7, 2 ",
            "3, 7, 6 ",
            "3, 9, 8 ",
            "5, 4, 7 ",
            "4, 2, 6 ",
            "3, 6, 8 ",
            "5, 8, 2 ",
            "7, 6, 8 ",
            "1, 7, 3 ",
            "6, 4, 3 ",
            "1, 8, 1 ",
            "1, 5, 7 ",
            "2, 6, 8 ",
            "13, 8, 2 ",
            "3, 5, 4 ",
            "1, 1, 2 ",
            "3, 6, 2 ",
            "1, 1, 4 ",
            "4, 4, 8 ",
            "8, 3, 1 ",
            "2, 4, 8 ",
            "15, 2, 4 ",
            "16, 8, 3 ",
            "1, 8, 6 ",
            "1, 7, 2 ",
            "8, 1, 2 ",
            "1, 6, 8 ",
            "6, 3, 1 ",
            "3, 3, 8 ",
            "6, 3, 1 ",
            "6, 2, 9 ",
            "2, 1, 4 ",
            "1, 8, 5 ",
            "8, 2, 9 ",
            "8, 1, 4 ",
            "3, 8, 6 ",
            "21, 4, 7 ",
            "1, 9, 7 ",
            "2, 6, 8 ",
            "1, 5, 1 ",
            "1, 3, 9 ",
            "8, 9, 4 ",
            "1, 1, 7 ",
            "1, 1, 4 ",
            "1, 6, 8 ",
            "1, 9, 3 ",
            "2, 9, 5 ",
            "2, 5, 3 ",
            "1, 9, 4 ",
            "3, 8, 2 ",
            "1, 1, 4 ",
            "4, 4, 9 ",
            "3, 3, 2 ",
            "5, 9, 1 ",
            "17, 7, 1 ",
            "1, 9, 1 ",
            "2, 2, 4 ",
            "1, 4, 2 ",
            "8, 2, 9 ",
            "5, 4, 5 ",
            "6, 4, 8 ",
            "20, 1, 6 ",
            "2, 9, 8 ",
            "1, 2, 9 ",
            "2, 8, 7 ",
            "8, 7, 8 ",
            "4, 5, 9 ",
            "14, 8, 7 ",
            "1, 5, 7 ",
            "7, 9, 1 ",
            "3, 6, 4 ",
            "3, 9, 7 ",
            "12, 6, 7 ",
            "22, 7, 9 ",
            "2, 2, 5 ",
            "10, 1, 7 ",
            "1, 4, 1 ",
            "2, 6, 1 ",
            "1, 1, 3 ",
            "2, 4, 8 ",
            "2, 8, 6 ",
            "1, 3, 8 ",
            "1, 4, 1 ",
            "2, 5, 3 ",
            "1, 8, 4 ",
            "2, 3, 7 ",
            "19, 9, 7 ",
            "1, 1, 4 ",
            "2, 9, 1 ",
            "2, 1, 6 ",
            "1, 6, 5 ",
            "42, 7, 8 ",
            "1, 7, 6 ",
            "2, 4, 8 ",
            "7, 6, 8 ",
            "2, 1, 5 ",
            "2, 9, 5 ",
            "14, 8, 3 ",
            "22, 8, 2 ",
            "3, 5, 6 ",
            "10, 8, 6 ",
            "5, 8, 9 ",
            "12, 6, 7 ",
            "2, 5, 1 ",
            "5, 3, 2 ",
            "7, 3, 5 ",
            "2, 5, 1 ",
            "2, 3, 7 ",
            "4, 1, 2 ",
            "1, 5, 7 ",
            "1, 5, 4 ",
            "1, 6, 2 ",
            "1, 9, 2 ",
            "9, 7, 3 ",
            "1, 4, 1 ",
            "3, 7, 5 ",
            "4, 3, 2 ",
            "5, 2, 3 ",
            "2, 5, 2 ",
            "34, 2, 9 ",
            "1, 1, 5 ",
            "15, 9, 3 ",
            "2, 3, 2 ",
            "1, 5, 4 ",
            "7, 3, 8 ",
            "3, 9, 2 ",
            "6, 9, 4 ",
            "5, 9, 3 ",
            "4, 4, 6 ",
            "1, 6, 8 ",
            "1, 3, 5 ",
            "6, 3, 2 ",
            "1, 4, 9 ",
            "2, 4, 2 ",
            "4, 5, 8 ",
            "1, 5, 6 ",
            "1, 7, 6 ",
            "1, 9, 6 ",
            "1, 7, 2 ",
            "12, 8, 7 ",
            "2, 7, 3 ",
            "4, 6, 9 ",
            "7, 9, 4 ",
            "9, 3, 9 ",
            "11, 7, 4 ",
            "3, 9, 6 ",
            "1, 4, 1 ",
            "15, 4, 3 ",
            "2, 4, 1 ",
            "3, 1, 4 ",
            "17, 3, 7 ",
            "4, 3, 7 ",
            "7, 9, 2 ",
            "3, 4, 1 ",
            "4, 6, 9 ",
            "1, 9, 6 ",
            "1, 3, 1 ",
            "5, 7, 9 ",
            "8, 9, 4 ",
            "1, 1, 6 ",
            "6, 4, 9 ",
            "4, 2, 3 ",
            "1, 4, 3 ",
            "1, 4, 9 ",
            "1, 1, 7 ",
            "1, 7, 9 ",
            "3, 6, 2 ",
            "9, 2, 3 ",
            "1, 9, 4 ",
            "1, 1, 5 ",
            "12, 7, 6 ",
            "4, 9, 8 " };

 //           string[] exampleMove = new string[] { "1 , 2 , 1",
 //"3 , 1 , 3",
 //"2 , 2 , 1",
 //"1 , 1 , 2"};
            int mov = 1;
            //foreach(var movement in moveStack)
            //{
            //    Console.WriteLine("movement = " + (mov));
            //    var temporary = movement.Split(",").ToArray();
            //    int stacks = Convert.ToInt32(temporary[0]);
            //    int stackFrom = Convert.ToInt32(temporary[1]);
            //    int stackTo = Convert.ToInt32(temporary[2]);

            //    var teststackFrom = suit[stackFrom-1];
            //    var teststackTo = suit[stackTo-1];

            //    Console.WriteLine("hasil FROM : " + teststackFrom);
            //    string finals = "";
            //    //string[] charArrays = new string[] { };
            //    for (int initailD = 0; initailD < stacks; initailD++)
            //    {
            //        var tmpChar =teststackFrom.ToArray()[initailD];
            //        finals = finals + tmpChar.ToString();
            //        //char[] charArray = teststackTo.ToCharArray();
            //        //Array.Reverse(charArray);
            //        //var plus = new string(charArray);
            //        //teststackTo = tmpChar.ToString() + plus;//   .ToList().Add(tmpChar);
            //        //char[] charArray2 = teststackTo.ToCharArray();
            //        //Array.Reverse(charArray2);
            //        //finals = new string(charArray2);
            //    }

            //    var tmpFinal = finals + teststackTo;

            //    Console.WriteLine("hasil FROM : " + string.Join("", tmpFinal));

            //    Console.WriteLine("hasil TO : " + finals);

            //    suit[stackTo - 1] = tmpFinal;
            //    var result3 = teststackFrom.ToArray().Skip(stacks).ToList().ToArray();   //.ToList().Remove(tmpChar);
            //    //teststackFrom = result3.ToList();//  .ToString();
            //    //var result1 = result3.ToArray();
            //    List<string> termsList = new List<string>();

            //    foreach (var jhony in result3)
            //    {
            //        termsList.Add(jhony.ToString());
            //    }

            //    Console.WriteLine("hasil FROM : " + string.Join("", termsList));

            //    suit[stackFrom - 1] = string.Join("", termsList);
                
            //    mov++;
            //}

            //foreach(var aplhacapa  in suit)
            //{
            //    Console.WriteLine("hasil : " + aplhacapa[0]);
            //}

            //////foreach(var inputan in suit)
            //////{
            //////    string words = inputan.Replace("-", "").Replace(",", "");

            //////    ////.Replace(",", "");

            //////    //var test = words[0].Replace("-","").ToList().ToArray().ToList();
            //////    //var test1 = words[1].Replace("-", "").ToList().ToArray().ToList();
            //////    var chars = words.ToArray();
            //////    //var chars1 = test.ToArray();

            //////    int begins = Convert.ToInt32(chars[0].ToString());
            //////    int ends = Convert.ToInt32(chars[1].ToString());

            //////    int begins1 = Convert.ToInt32(chars[2].ToString());
            //////    int ends1 = Convert.ToInt32(chars[3].ToString());

            //////    IEnumerable<int> squaresOne = Enumerable.Range(begins, (ends)).Where(o => o <= ends).ToArray();  //.Select(x => x);

            //////    IEnumerable<int> squaresTwo = Enumerable.Range(begins1, (ends1)).Where(o => o <= ends1).ToArray();   //.Select(o => o);

            //////    if (squaresOne.ToArray().Length <= squaresOne.ToArray().Length)
            //////    {
            //////        if (squaresTwo.Contains(Convert.ToInt32(squaresOne.First())) && squaresTwo.Contains(Convert.ToInt32(squaresOne.Last())))
            //////        {
            //////            Console.WriteLine("[{0}]", string.Join(", ", squaresTwo.ToArray()));
            //////            Console.WriteLine("TRUE");
            //////        }
            //////    }
            //////    else
            //////    {
            //////        if (squaresOne.Contains(Convert.ToInt32(squaresTwo.First())) && squaresOne.Contains(Convert.ToInt32( squaresTwo.Last())))
            //////        {
            //////            Console.WriteLine("[{0}]", string.Join(", ", squaresTwo.ToArray()));
            //////            Console.WriteLine("TRUE");
            //////        }
            //////    }
            //////}

            //string[] data = new string[] { "2-5,6-7" };
            //string words = data[0].Replace("-", "").Replace(",", "");

            //////.Replace(",", "");

            ////var test = words[0].Replace("-","").ToList().ToArray().ToList();
            ////var test1 = words[1].Replace("-", "").ToList().ToArray().ToList();
            //var chars = words.ToArray();
            ////var chars1 = test.ToArray();

            //int begins = Convert.ToInt32(chars[0].ToString());
            //int ends = Convert.ToInt32(chars[1].ToString());

            //int begins1 = Convert.ToInt32(chars[2].ToString());
            //int ends1 = Convert.ToInt32(chars[3].ToString());

            //IEnumerable<int> squaresOne = Enumerable.Range(begins, (ends)).Where( o => o <= ends).ToArray();  //.Select(x => x);

            //IEnumerable<int> squaresTwo = Enumerable.Range(begins1, (ends1)).Where(o => o <= ends1).ToArray();   //.Select(o => o);

            //if (squaresOne.ToArray().Length <= squaresOne.ToArray().Length)
            //{
            //    if(squaresTwo.Contains(Convert.ToInt32(squaresOne.Last())) && squaresTwo.Contains(Convert.ToInt32(squaresOne.Last())))
            //    {
            //        Console.WriteLine("TRUE");
            //    }
            //}

            int tmp = 0;
            int sumo = 0;


            /////// Day 4 1-2
            ////foreach (var inputan in suit)
            ////{
            ////    string[] words = inputan.Split(","); //.Replace("-", "").Replace(",", "");

            ////    ////.Replace(",", "");

            ////    //var test = words[0].Replace("-","").ToList().ToArray().ToList();
            ////    //var test1 = words[1].Replace("-", "").ToList().ToArray().ToList();
            ////    string[] chars = words[0].Split("-");
            ////    string[] chars1 = words[1].Split("-");

            ////    //.ToArray();
            ////    //var chars1 = test.ToArray();


            ////    int begins = Convert.ToInt32(chars[0].ToString());
            ////    int ends = Convert.ToInt32(chars[1].ToString());

            ////    int begins1 = Convert.ToInt32(chars1[0].ToString());
            ////    int ends1 = Convert.ToInt32(chars1[1].ToString());

            ////    int tmpUMUM;
            ////    if(begins > ends)
            ////    {
            ////        tmpUMUM = begins;
            ////        begins = ends;
            ////        ends = begins;
            ////    }

            ////    if (begins1 > ends1)
            ////    {
            ////        tmpUMUM = begins1;
            ////        begins1 = ends1;
            ////        ends1 = begins1;
            ////    }

            ////    IEnumerable<int> squaresOne = Enumerable.Range(begins, (ends)).Where(o => o <= ends).ToArray();  //.Select(x => x);

            ////    IEnumerable<int> squaresTwo = Enumerable.Range(begins1, (ends1)).Where(o => o <= ends1).ToArray();   //.Select(o => o);

            ////    if (squaresOne.ToArray().Length != 0 && squaresTwo.ToArray().Length != 0)
            ////    {
            ////        if (squaresOne.ToArray().Length <= squaresTwo.ToArray().Length)
            ////        {
            ////            if (squaresTwo.Contains(Convert.ToInt32(squaresOne.First())) || squaresTwo.Contains(Convert.ToInt32(squaresOne.Last())))
            ////            {
            ////                Console.WriteLine("[{0}]", string.Join(", ", squaresTwo.ToArray()));
            ////                Console.WriteLine("TRUE");
            ////                tmp += 1;
            ////            }
            ////        }
            ////        else
            ////        {
            ////            if (squaresOne.Contains(Convert.ToInt32(squaresTwo.First())) || squaresOne.Contains(Convert.ToInt32(squaresTwo.Last())))
            ////            {
            ////                Console.WriteLine("[{0}]", string.Join(", ", squaresTwo.ToArray()));
            ////                Console.WriteLine("TRUE");
            ////                tmp += 1;
            ////            }
            ////        }
            ////    }
            ////    else
            ////    {
            ////        tmp += 1;
            ////    }               
            ////}

            Console.WriteLine(tmp);

            string[] lowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r"
            , "s", "t", "u", "v", "w", "x", "y", "z"};

            string[] upperCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R"
            , "S", "T", "U", "V", "W", "X", "Y", "Z"};

            //for (int initailD = 0; initailD < Convert.ToInt32(jumlahKeluarga); initailD+=3)
            //{
            //    var examples = suit[initailD].Count();
            //    var testbegin = suit[initailD].ToList(); //.Take(examples / 2);
            //    var testlast = suit[initailD + 1].ToList();
            //    var testmin = suit[initailD + 2].ToList();

            //    //Console.WriteLine("[{0}]", string.Join(", ", testlast.ToArray()));
            //    //var deomon = suit[i].ToArray();
            //    //Array.Reverse(deomon);
            //    //var testbegin = deomon.ToList().Take(examples / 2);
            //    //Console.WriteLine("[{0}]", string.Join(", ", testbegin));
            //    //var jonnies = testbegin;
            //    var CommonList1 = testbegin.Intersect(testlast);
            //    //Console.WriteLine("[{0}]", string.Join(", ", CommonList1.ToArray()));

            //    var CommonList2 = testmin.Intersect(testbegin);
            //    //Console.WriteLine("[{0}]", string.Join(", ", CommonList2.ToArray()));

            //    var CommonList3 = testlast.Intersect(testmin);
            //    //Console.WriteLine("[{0}]", string.Join(", ", CommonList3.ToArray()));


            //    List<List<char>> listOfLists = new List<List<char>>() { CommonList1.ToList() , CommonList2.ToList(), CommonList3.ToList() };

            //    //var intersection = listOfLists.Aggregate((previousList, nextList) => previousList.Intersect(nextList).ToList());

            //    var intersections = listOfLists
            //        .Skip(1)
            //        .Aggregate(
            //            new HashSet<char>(listOfLists.First()),
            //            (h, e) => { h.IntersectWith(e); return h; }
            //        );


            //    foreach (var memberss in intersections)
            //    {
            //        if (Char.IsLower(memberss))
            //        {
            //            var value = Array.IndexOf(lowerCase, memberss.ToString());
            //            sumo += (value + 1);
            //        }
            //        else
            //        {
            //            var value = Array.IndexOf(upperCase, memberss.ToString());
            //            sumo += (value + 27);
            //        }
            //    }
            //}


            //var suitsDictionary = new Dictionary<string, int>(){
            //    {"A Z", 8},
            //    {"B Z", 9},
            //    {"C Z", 7},
            //    {"A X", 3},
            //    {"B X", 1},
            //    {"C X", 2}
            //};

            ////// No.2
            //for (int i = 0; i < Convert.ToInt32(jumlahKeluarga); i++)
            //{
            //    if (suit[i].Contains("Z"))
            //    {
            //        sumo += suitsDictionary[suit[i]];

            //    }else if (suit[i].Contains("Y"))
            //    {
            //        if (suit[i].Contains("A"))
            //        {
            //            sumo += 4;
            //        }
            //        else if (suit[i].Contains("B"))
            //        {
            //            sumo += 5;
            //        }
            //        else
            //        {
            //            sumo += 6;
            //        }
            //    }
            //    else
            //    {
            //        sumo += suitsDictionary[suit[i]];
            //    }

            Console.WriteLine(sumo);
            //if (suit[i].Contains("A Y") || suit[i].Contains("B Z") || suit[i].Contains("C X"))
            //{
            //    sumo += 6;
            //    if (suit[i].Contains("Y"))
            //    {
            //        sumo += 2;
            //    }
            //    else if (suit[i].Contains("X"))
            //    {
            //        sumo += 1;
            //    }
            //    else
            //    {
            //        sumo += 3;
            //    }
            //    Console.WriteLine(sumo);
            //}
            //else  
            //{
            //    if(suit[i].Contains("C Z") || suit[i].Contains("A X") || suit[i].Contains("B Y"))
            //    {
            //        sumo += 3;
            //        if (suit[i].Contains("Y"))
            //        {
            //            sumo += 2;
            //        }
            //        else if (suit[i].Contains("X"))
            //        {
            //            sumo += 1;
            //        }
            //        else
            //        {
            //            sumo += 3;
            //        }
            //    }
            //    else
            //    {
            //        if (suit[i].Contains("Y"))
            //        {
            //            sumo += 2;
            //        }
            //        else if (suit[i].Contains("X"))
            //        {
            //            sumo += 1;
            //        }
            //        else
            //        {
            //            sumo += 3;
            //        }
            //    }
            //    Console.WriteLine(sumo);
            //}
        }

        //Console.WriteLine( "total :" + sumo);

        //// No.1
        //for (int i = 0; i < Convert.ToInt32(jumlahKeluarga); i++)
        //{
        //    if (anggota[i] == 0)
        //    {
        //        raindears.Append(sumo);
        //        example.Add(sumo);
        //        if (tmp < sumo)
        //        {
        //            tmp = sumo;
        //            sumo = 0;
        //        }
        //        else
        //        {
        //            sumo = 0;
        //        }
        //    }else
        //    {
        //        sumo = sumo + anggota[i];
        //    }


        //}
        //raindears = example.ToArray();
        //Array.Sort(raindears);
        //Array.Reverse(raindears);

        //var jomioas = raindears.ToList().Take(3);

        //Console.WriteLine(jomioas.Sum());


        ////int totalbuss = 0;

        ////Array.Sort(anggota);
        ////if (Convert.ToInt32(jumlahKeluarga) == falg)
        ////{

        ////    var dominos = anggota.ToList();
        ////    List<int> dominatorinvalid = new List<int>();

        ////    foreach (var invalid in anggota)
        ////    {
        ////        if (invalid > 4)
        ////        {
        ////            dominos.Remove(Convert.ToInt32(invalid));
        ////        }
        ////    }

        ////    var jonis = dominos; 


        ////    List <int> dominator = new List<int>();

        ////    if (anggota.ToList().Where(x => x <= 4).Sum() % 2 != 0)
        ////    {
        ////        foreach (var found in GetItems(anggota.ToList().Where(x => x <= 4), 3))
        ////        {
        ////            foreach (var itemFound in found)
        ////            {
        ////                dominator.Add(itemFound);
        ////            }

        ////        }

        ////    }

        ////    foreach (var found in GetItems(anggota.ToList().Where(x => x <= 4), 4))
        ////    {
        ////        foreach(var itemFound in found)
        ////        {
        ////            dominator.Add(itemFound);
        ////        }
        ////    }

        //List<int> dominatorTest = new List<int>();

        //foreach (var found in GetItems(anggota.ToList().Where(x => x <= 4), 4))
        //{
        //    foreach (var itemFound in found)
        //    {
        //        dominatorTest.Add(itemFound);
        //    }
        //}
        //Console.WriteLine("[{0}]", string.Join(", ", dominatorTest.ToArray()));


        ////if (anggota.ToList().Where(x => x <= 4).Sum() % 2 != 0 && anggota.ToList().Where(x => x <= 4).Sum() !=5)
        ////{
        ////    dominator.Reverse();
        ////}

        ////if (anggota.Sum() <= 2)
        ////{
        ////    foreach (var found in GetItems(anggota.ToList().Where(x => x <= 4), 1))
        ////    {
        ////        foreach (var itemFound in found)
        ////        {
        ////            dominator.Add(itemFound);
        ////        }

        ////    }
        ////}


        ////var pool = dominator.ToArray();

        ////var testmemo = anggota.ToList().Where(x => x <= 4).Sum();

        ////if (anggota.ToList().Where(x => x <= 4).Sum() % 2 == 0)
        ////{
        ////    Array.Reverse(pool);
        ////}


        ////if (pool.Length < jonis.ToArray().Length)
        ////{
        ////    pool = jonis.ToArray();
        ////    Array.Reverse(pool);
        ////}

        ////int tmpdomini = 0;
        //////Console.WriteLine("[{0}]", string.Join(", ", pool.ToArray()));

        ////for (int pil = 0; pil < pool.Length; pil++)
        ////{
        ////    tmpdomini = tmpdomini + pool.ToArray()[pil];
        ////    if (tmpdomini > 4)
        ////    {
        ////        if (jonis.Remove(pool.ToArray()[pil]))
        ////        {
        ////            totalbuss++;
        ////            tmpdomini = 0;
        ////        };
        ////        tmpdomini = pool.ToArray()[pil];
        ////        if (jonis.ToArray().Length == 0 && tmpdomini != 0)
        ////        {
        ////            totalbuss++;
        ////            break;
        ////        }
        ////    }
        ////    else if(tmpdomini <= 4)
        ////    {
        ////        jonis.Remove(pool.ToArray()[pil]);


        ////        if (jonis.ToArray().Length == 0 && tmpdomini != 0)
        ////        {
        ////            totalbuss++;
        ////            break;
        ////        }
        ////    }

        ////}

        ////Console.WriteLine("bus :" + totalbuss);
        //}
        
    }
}