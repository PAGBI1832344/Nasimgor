using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasimgor
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 0;
            int nb = 0;
            Console.WriteLine("-----Les aventures de Nasimgor-----");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Bonjour,les règles du jeu sont très simples.Vous avez tout simplement a répondre a chaque choix par 1 ou 2 selon l'aventure que vous désirez mener!");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Vous commencez l'aventure avec 5 points de vies ,bonne chance !");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("....................");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Après de longues années dans le comas,le jeune garçon appelé Nasimgor se reveilla au coté d'un vieux sage.Celui si veilla sur lui depuis ces années.");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Dès que Nasimgor ouvra ses yeux le vieil homme lui parla d'un fameux monstre légendaire.Zorlax!");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Ce fameux monstre aux apparences multiples règna la terreur partout dans le royaume suite aux nombreuses destruction de villages qu'il a fait.");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Nasimgor dit a l'homme qu'il veut se charger de cette affaire.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Presser de partir a la recherche de ce monstre vous vous precipitez vers la sotie de la résidence du vieux sage.");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("Attends petit! dit le vieux sage.Il veut dabord vous proposer quelque chose avant de partir a l'aventure.");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("....................");
            Console.WriteLine("Pour vous assisté il vous proposa soit de prendre une épée et perdre 1 point de vie ou bien de gagner +10 d'agilité sans rien perdre ,choisissez minutieusement!");
            Console.WriteLine("1- Épée - 1 point de vie.");
            Console.WriteLine("2- +10 d'agilité");
            choix = Convert.ToInt32(Console.ReadLine());

            if(choix==1) //Premiere branche(premier choix)//
            {
                Console.Clear();
                Console.WriteLine("Vous êtes maintenant muni d'une épée mais vous avez perdu 1 point de vie donc il vous en reste 4!");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("Vous avez le choix de partir par la forêt pour aller au village de K'himmar ou bien par la plaine vers le village O'rgamil.");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("1- K'himmar");
                Console.WriteLine("2- O'rgamil");
                choix = Convert.ToInt32(Console.ReadLine());
                if ( choix ==1) //2 ieme choix//
                {
                    Console.Clear();
                    Console.WriteLine("Vous partez vers la forêt et tomber sur un loup.Heureusement vous êtes muni d'une épée donc vous le tuer avec succes et vous rendez au village.");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("À l'entrée du village un garde interragit avec vous et vous parla d'un sbire de Zorlax qui est en fait un lézard géant à quelques kilomètres de ce lieu.Celui-ci vous fournit un bouclier pour la bataille.Il vous proposa également de vous rendre a la cité perdu de K'himmar sans vous en dire plus.");
                    System.Threading.Thread.Sleep(6000);
                    Console.WriteLine("1- Combattre le Lézard.");
                    Console.WriteLine("2- Aller vers la cité perdu.");
                    choix = Convert.ToInt32(Console.ReadLine());
                    if ( choix==1) //3 ieme choix//
                    {
                        Console.Clear();
                        Console.WriteLine("Rendu sur les lieux vous faites face au lézard et il engagea le combat en vous donnant un coup de griffe se qui brisa votre bouclier et avant meme pouvoir riposter il vous enchaîna avec un coup de queue ce qui vous tua instantanément");
                        System.Threading.Thread.Sleep(7000);
                        Console.WriteLine("VOUS ÊTES MORT !");  //fINI//
                    }
                    else if(choix==2) //3 ieme choix//
                    {
                        Console.Clear();
                        Console.WriteLine("Vous vous déplacer vers le Nord pour vous rendre à la cité perdu.");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("Une fois arrivé sur les lieux vous voyez une silhouette.C'est le gardien de la cité perdu ,il est armé d'une grande épée.Incertain, vous avancer pour aller lui parler et il vous demanda si vous pouvez l'aider a déplacer un rocher pour bloquer l'acces d'une entrée secr" +
                            "ete.");
                        System.Threading.Thread.Sleep(5500);
                        Console.WriteLine(" Acceptez-vous d'aider le gardien ?");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("1- oui");
                        Console.WriteLine("2- non");
                        choix = Convert.ToInt32(Console.ReadLine());
                        if(choix==1) //4 ieme choix//
                        {
                            Console.Clear();
                            Console.WriteLine("Vous gagnez +10 de force en deplacant le rocher.");
                            System.Threading.Thread.Sleep(1500);
                            Console.WriteLine("Grâce a vos 10 points de force,vous pouvez maintenant manier l'épée lourde a deux mains .Voulez-vous aller a K'himmar pour voir le spécialistes des épées à deux mains ou bien aller a O'rgamil pour le spécialiste d'épées a une main.");
                            System.Threading.Thread.Sleep(5000);
                            Console.WriteLine("1- K'himmar");
                            Console.WriteLine("2- O'rgamil");
                            choix = Convert.ToInt32(Console.ReadLine());
                            if(choix==1) // 5 ieme choix//
                            {
                                Console.Clear();
                                Console.WriteLine("Rendu devant le spécialiste d'épée a deux mains ,vous lui dites prêt a commencer l'entrainement pour le maniement de ce genre d'épée.");
                                System.Threading.Thread.Sleep(3500);
                                Console.WriteLine("Après l'entrainement,vous recevez une épée a deux mains.Vous gagnez également 10 de force pour faire des attaques plus puissantes.");
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine("L'entraineur vous proposer d'aller vaincre le sbire de Zorlax qui est un lézard géant et de ramener une écaille en échange d'une armure ou bien d'aller vaincre Zorlax immédiatement.");
                                System.Threading.Thread.Sleep(3500);
                                Console.WriteLine("1- Vaincre le sbire.");
                                Console.WriteLine("2- Vaincre Zorlax.");
                                choix = Convert.ToInt32(Console.ReadLine());
                                if (choix==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Donc, vous partez vers l'ouest à quelques kilomètres pour battre le lézard géant");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("Arrivé sur place vous engagé le combat mais il se retourne et vous projetta d'un coup de griffe.");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("Vous perdez 2 points de vie.IL ne vous en reste plus que 2.");
                                    System.Threading.Thread.Sleep(1500);
                                    Console.WriteLine("Sur vos gardes,vous reussissez a lui mettre un coup d'épée sur une patte ce qui lui coupa celle-ci.Désequilibré,la bête s'écroula et vous l'achever en lui tranchant la tête.");
                                    System.Threading.Thread.Sleep(3500);
                                    Console.WriteLine("Vous arrachez une écaille du lézard et reparter en ville pour avoir votre armure.Arrivé en ville vous recevez votre armure.");
                                    System.Threading.Thread.Sleep(2500);
                                    Console.WriteLine("Félicitation vous gagnez 4 d'armure donc il vous reste 2 points de vie et 4 points d'armure");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("Avec votre armure vous vous sentez prêt à aller vaincre Zorlax.Vous partez vers l'antre pour lui faire la peau!");
                                    System.Threading.Thread.Sleep(2500);
                                    Console.WriteLine("Sur place, vous vous précipitez vers lui et donna un coup d'épée avec grande puissance ce qui lui coupa la queue.");
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine("Zorlax se retourna instantanément et vous donna un coup de griffe empoisonné ce qui brûla votre armure,-4 point d'armure.");
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine("Attention il vous reste 2 points de vie!");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Vous avez le choix de reculer ou de vous dépêcher de lui lancer une autre attaque .");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("1- Reculer.");
                                    Console.WriteLine("2- Lancer une attaque.");
                                    choix = Convert.ToInt32(Console.ReadLine());
                                    if ( choix==1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("En reculant,le monstre s'approchea de vous mais en déséquilibre puisqu'il n'a plus de queue,vous profitez de cette occasion pour lui donner un coup final dans son coeur il moura sur le coup.");
                                        System.Threading.Thread.Sleep(3500);
                                        Console.WriteLine("Vous avez accompli votre objectif avec succès!Le royaume n'a plus rien à craindre.");
                                        System.Threading.Thread.Sleep(2000);
                                        Console.WriteLine("Félicitation vous avez passé le jeu!");
                                    }
                                    else if(choix==2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Le monstre riposta plus vite que vous ,il vous mangea tout simplement.Vous n'avez été qu'un repas de plus pour lui!");
                                        System.Threading.Thread.Sleep(3000);
                                        Console.WriteLine("VOUS ÊTES MORT !");
                                    }
                                }
                                else if(choix==2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vous prenez route vers l'antre de Zorlax confiant.Une fois sur place vous entrez et vous donnez un coup d'épée sur la queue de lame de Zorlax avant qu'il ne vous aperçois et vous couper sa queue.");
                                    System.Threading.Thread.Sleep(4000);
                                    Console.WriteLine("Cependant,il vous donna un coup de griffe empoisonné qui metta fin a vos jours.");
                                    System.Threading.Thread.Sleep(2500);
                                    Console.WriteLine("VOUS ÊTES MORT !"); //fini//
                                }
                            }
                            else if(choix==2)
                            {
                                Console.Clear();
                                Console.WriteLine("Rendu devant le spécialiste d'épée a une main, vous recevez une épée légèrement plus puissante.");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Vous vous sentez prêt a faire face a Zorlax donc vous vous rendez a son antre immédiatement . ");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Une fois rendu vous vous approchez et donnez un coup d'épée.Malheureusement, l'épée légère n'arrive meme pas à faire une égratignure au monstre.Celui-ci se retourna et vous donna un coup de queue en lame se qui causa votre mort. ");
                                System.Threading.Thread.Sleep(5000);
                                Console.WriteLine(" VOUS ÊTES MORT !"); //fini//


                            }

                        }
                        else if( choix==2) // 4 ieme choix//
                        {
                            Console.Clear();
                            Console.WriteLine("Par votre lacheté le gardien vous exécuta d'un seul coup d'épée!");
                            System.Threading.Thread.Sleep(2500);
                            Console.WriteLine("VOUS ÊTES MORT !");  //fini//
                        }
                    }

                }
                else if (choix==2) // ATTENTION PAS OUBLIER DE COPIER//
                {
                    Console.Clear();
                    Console.WriteLine("Vous parter vers la plaine et lors du trajet tout est calme jusqu'a ce qu'une plante vous aggripe la jambe et vous inflige 1 de dégat vous reussissez tout de même a vous rendre a O'rgamil mais vous vous en sortez avec 3 points de vies");
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("Une fois au village, un passant vous dit d'aller a la cité perdu de K'himmar. A mi-chemin un temple s'y repose ,il vous conseilla donc d,Emprunter ce chemin et y faire un arrêt.");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("Rendu au temple sacré, un moine vous acceuille chaleureusement et vous donna un calice rempli d'eau. C'étais en fais de l'eau régénerante ce qui vous redonne 1 point de vie . ");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine(" Vous êtes de nouveau a 4 points de vies.");
                    System.Threading.Thread.Sleep(2000);
                    Console.Write("Vous continuez votre chemin vers la cité perdu.");
                    System.Threading.Thread.Sleep(2500);
                    Console.WriteLine("Une fois arrivé sur les lieux vous voyez une silhouette.C'est le gardien de la cité perdu ,il est armé d'une grande épée.Incertain, vous avancer pour aller lui parler et il vous demanda si vous pouvez l'aider a déplacer un rocher pour bloquer l'acces d'une entrée secr" +
                        "ete.");
                    System.Threading.Thread.Sleep(5500);
                    Console.WriteLine(" Acceptez-vous d'aider le gardien ?");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("1- oui");
                    Console.WriteLine("2- non");
                    choix = Convert.ToInt32(Console.ReadLine());
                    if (choix == 1) //4 ieme choix//
                    {
                        Console.Clear();
                        Console.WriteLine("Vous gagnez +10 de force en deplacant le rocher.");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Grâce a vos 10 points de force,vous pouvez maintenant manier l'épée lourde a deux mains .Voulez-vous aller a K'himmar pour voir le spécialiste des épées à deux mains ou bien a ller a O'rgamil pour le spécialiste d'épées a une main.");
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("1- K'himmar");
                        Console.WriteLine("2- O'rgamil");
                        choix = Convert.ToInt32(Console.ReadLine());
                        if (choix == 1) // 5 ieme choix//
                        {
                            Console.Clear();
                            Console.WriteLine("Rendu devant le spécialiste d'épée a deux mains ,vous lui dites prêt a commencer l'entrainement pour le maniement de ce genre d'épée.");
                            System.Threading.Thread.Sleep(3500);
                            Console.WriteLine("Après l'entrainement,vous recevez une épée a deux mains.Vous gagnez également 10 de force pour faire des attaques plus puissantes.");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("L'entraineur vous proposer d'aller vaincre le sbire de Zorlax qui est un lézard géant et de ramener une écaille en échange d'une armure ou bien d'aller vaincre Zorlax immédiatement.");
                            System.Threading.Thread.Sleep(3500);
                            Console.WriteLine("1- Vaincre le sbire.");
                            Console.WriteLine("2- Vaincre Zorlax.");
                            choix = Convert.ToInt32(Console.ReadLine());
                            if (choix == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Donc, vous partez vers l'ouest à quelques kilomètres pour battre le lézard géant");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Arrivé sur place vous engagé le combat mais il se retourne et vous projetta d'un coup de griffe.");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Vous perdez 2 points de vie.IL ne vous en reste plus que 2.");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("Sur vos gardes,vous reussissez a lui mettre un coup d'épée sur une patte ce qui lui coupa celle-ci.Désequilibré,la bête s'écroula et vous l'achever en lui tranchant la tête.");
                                System.Threading.Thread.Sleep(3500);
                                Console.WriteLine("Vous arrachez une écaille du lézard et reparter en ville pour avoir votre armure.Arrivé en ville vous recevez votre armure.");
                                System.Threading.Thread.Sleep(2500);
                                Console.WriteLine("Félicitation vous gagnez 4 d'armure donc il vous reste 2 points de vie et 4 points d'armure");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Avec votre armure vous vous sentez prêt à aller vaincre Zorlax.Vous partez vers l'antre pour lui faire la peau!");
                                System.Threading.Thread.Sleep(2500);
                                Console.WriteLine("Sur place, vous vous précipitez vers lui et donna un coup d'épée avec grande puissance ce qui lui coupa la queue.");
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine("Zorlax se retourna instantanément et vous donna un coup de griffe empoisonné ce qui brûla votre armure,-4 point d'armure.");
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine("Attention il vous reste 2 points de vie!");
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("Vous avez le choix de reculer ou de vous dépêcher de lui lancer une autre attaque .");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("1- Reculer.");
                                Console.WriteLine("2- Lancer une attaque.");
                                choix = Convert.ToInt32(Console.ReadLine());
                                if (choix == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("En reculant,le monstre s'approchea de vous mais en déséquilibre puisqu'il n'a plus de queue,vous profitez de cette occasion pour lui donner un coup final dans son coeur il moura sur le coup.");
                                    System.Threading.Thread.Sleep(3500);
                                    Console.WriteLine("Vous avez accompli votre objectif avec succès!Le royaume n'a plus rien à craindre.");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("Félicitation vous avez passé le jeu!");
                                }
                                else if (choix == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Le monstre riposta plus vite que vous ,il vous mangea tout simplement.Vous n'avez été qu'un repas de plus pour lui!");
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine("VOUS ÊTES MORT !");


                                }
                            }
                            else if (choix == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Vous prenez route vers l'antre de Zorlax confiant.Une fois sur place vous entrez et vous donnez un coup d'épée sur la queue de lame de Zorlax avant qu'il ne vous aperçois et vous couper sa queue.");
                                System.Threading.Thread.Sleep(4000);
                                Console.WriteLine("Cependant,il vous donna un coup de griffe empoisonné qui metta fin a vos jours.");
                                System.Threading.Thread.Sleep(2500);
                                Console.WriteLine("VOUS ÊTES MORT !"); //fini//
                            }
                        else if (choix == 2)
                        {
                           Console.Clear();
                           Console.WriteLine("Rendu devant le spécialiste d'épée a une main, vous recevez une épée légèrement plus puissante.");
                           System.Threading.Thread.Sleep(2000);
                           Console.WriteLine("Vous vous sentez prêt a faire face a Zorlax donc vous vous rendez a son antre immédiatement . ");
                           System.Threading.Thread.Sleep(2000);
                           Console.WriteLine("Une fois rendu vous vous approchez et donnez un coup d'épée.Malheureusement, l'épée légère n'arrive meme pas à faire une égratignure au monstre.Celui-ci se retourna et vous donna un coup de queue en lame se qui causa votre mort. ");
                           System.Threading.Thread.Sleep(5000);
                           Console.WriteLine(" VOUS ÊTES MORT !"); //fini//


                        }
                        }
                    }
                    else if (choix == 2) // 4 ieme choix//
                    {
                        Console.Clear();
                        Console.WriteLine("Par votre lacheté le gardien vous exécuta d'un seul coup d'épée!");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("VOUS ÊTES MORT !");  //fini//
                    }


                }
            }
            else if(choix==2) //Deuxieme branche(premier choix//
            {
                Console.Clear();
                Console.WriteLine("Vous avez gagné +10 d'agilité!Çela pourrait vous être utile plus tard.");
                Console.WriteLine("Vous avez le choix de partir par la forêt pour aller au village de K'himmar ou bien par la plaine vers le village O'rgamil.");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("1- K'himmar");
                Console.WriteLine("2- O'rgamil");
                choix = Convert.ToInt32(Console.ReadLine());
                if ( choix==1) // 2 ieme  choix//
                {
                    Console.WriteLine("Vous partez vers la forêt et tomber sur un loup,malheureusement vous n'avez rien pour vous défendre donc vous fous faites mordre et réussissez a fuir vers K'himmar par apres .Vous perdez 1 point de vie il vous en reste plus que 4.");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("Rendu a K'himmar, un archer novice avait pour mission d'aller tuer un griffon dans les plaines rocheuses pas loin du village et il vous offre sa mission .Il vous fournit un arc et des flèches en fer.Acceptez-vous ou préférez-vous aller voir un maitre de l'archierie pour vous entrainer? ");
                    System.Threading.Thread.Sleep(6000);
                    Console.WriteLine("1- Aller vaincre le griffon.");
                    Console.WriteLine("2- Aller voir le maitre de l'archierie");
                    choix = Convert.ToInt32(Console.ReadLine());
                    if(choix==1)
                    {
                        Console.Clear();
                        Console.WriteLine("Arrivé sur les plaines rocheuses,vous apercevez le volatile.Vous engagez le combat en lanca une flèche mais vous n'avez pas d'expérience vous ratez misérablement votre tir.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("Le griffon vous empoigna avec ses griffes et vous monta en hauteur pour vous laisser tomber de super haut et vous mourrez sur le coup.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("VOUS ÊTES MORT !");
                    }
                    else if(choix==2)
                    {
                        Console.Clear();
                        Console.WriteLine("Rendu au centre d'archer, le maitre vous accepte grâce a vos 10 point d'agilité.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("L'entrainement commence.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Une fois l'entrainement terminé, vous avez appris a maitriser les flèches en or.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("Vous avez gagné +10 d'agilité.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Voulez vous continuer votre entrainement ou plutôt partir a l'aventure?");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("1- Continuer l'entrainement.");
                        Console.WriteLine("2- Partir à l'aventure.");
                        choix = Convert.ToInt32(Console.ReadLine());
                        if(choix==1)
                        {
                            Console.Clear();
                            Console.WriteLine("Vous continuez votre entrainement avec l'archer en chef.");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("L'entrainement se termine et le maitre archer vous juge prêt puisque vous maitriser maintenant les flèches en diamant ceux-ci transpercent n'importe quelle peau.");
                            System.Threading.Thread.Sleep(6000);
                            Console.WriteLine("Suite a l'affirmation de l'entraineur vous partez vers l'antre de Zorlax pour en finir une fois pour tout.");
                            System.Threading.Thread.Sleep(4000);
                            Console.WriteLine("En chemin vous croisez un griffon qui vous prend comme proie.Cependant,vous avez gagné beaucoup d'agilité et d'expérience en archerie donc vous ne ratez aucune flèche ....Sauf une et c'est a ce moment que le volatile réussi a vous toucher ce qui vous inflige 1 point de vie");
                            System.Threading.Thread.Sleep(8000);
                            Console.WriteLine("Il vous reste 3 points de vie.");
                            System.Threading.Thread.Sleep(1500);
                            Console.WriteLine("Vous lui tirez une dernière flèche ce qui le tua.Vous pouvez donc continuer votre route vers le monstre légendaire et en finir.");
                            System.Threading.Thread.Sleep(5000);
                            Console.WriteLine("Vous pénétrer dans le domaine de Zorlax et lui lancez une flèche qui lui transpèrce une patte il se retourne et vous projetta dans un rocher avec un coup de queue.Cela vous enlève 2 points de vie");
                            System.Threading.Thread.Sleep(6000);
                            Console.WriteLine("Attention vous avez 1 point de vie,vous êtes dans un état critique.");
                            System.Threading.Thread.Sleep(2500);
                            Console.WriteLine("Vous avez le choix de rester au rocher et d'enchaîner les flèches sur le monstre ou bien d'éxecuter une roulade vers un autre rocher pour lui lancer des flèches.");
                            System.Threading.Thread.Sleep(5500);
                            Console.WriteLine("1- Rester");
                            Console.WriteLine("2- Roulade");
                            choix = Convert.ToInt32(Console.ReadLine());
                            if(choix==1)
                            {
                                Console.Clear();
                                Console.WriteLine("Vous restez immobile en lancant des flèches qui infligent de grosses blessures à votre adversaire,mais vous êtes une proie facile alors il arrivent a vous achevez en vous donnant seulement un coup de patte. ");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("VOUS ÊTES MORT !");
                            }
                            else if (choix==2)
                            {
                                Console.Clear();
                                Console.WriteLine("Après avoir fait une roulade vers un autre rocher le monstre a eu du mal a vous suivre dû a votre rapidité donc vous reussissez a lui tirer une flèche dans son seul oeil et par après vous l'achever aisément en lui tirant une rafale de flèche dans son corps.");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("Félicitations,vous avez mis fin a la terreur dans le royaume.");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Vous avez passé le jeu!");

                            }
                                    
                        }
                        else if(choix==2)
                        {
                            Console.Clear();
                            Console.WriteLine("Vous avez le choix d'aller vaincre un lézard géant qui est le sbire de Zorlax ou d'aller vaincre Zorlax en personne.");
                            System.Threading.Thread.Sleep(3500);
                            Console.WriteLine("1- Vaincre le sbire.");
                            Console.WriteLine("2- Vaincre Zorlax");
                            choix = Convert.ToInt32(Console.ReadLine());
                            if(choix==1)
                            {
                                Console.Clear();
                                Console.WriteLine("Unw fois arrivé sur place,vous menez un long combat contre le Lézard vous esquivez quelques attaques de suite et épuisez vos réserves de flèche peu a peu.");
                                System.Threading.Thread.Sleep(4000);
                                Console.WriteLine("Il réussi a vous donné un coup de griffe avec sa patte ce qui vous ouvre le ventre et vous inflige 3 de dégats.");
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine("Il vous reste 1 point de vie.");
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("Vous avez 1 chance sur 2 de réussir à toucher la dernière flèche sur le Lézard ce qui lui serait fatale.");
                                System.Threading.Thread.Sleep(3000);
                                Random generateurNb = new Random();
                                nb = (int)generateurNb.Next(1, 11);
                                if(nb<=5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Votre flèche a achever le sbire!");
                                    System.Threading.Thread.Sleep(1500);
                                    Console.WriteLine("Sur le chemin du retour vous mourrez d'hémoragie puisque votre ventre était trop ouvert.");
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine("Vous avez perdu votre dernier point de vie.");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("VOUS ÊTES MORT !");  
                                }
                                else if(nb>=6)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vous ratez votre cible et succombez à la dernière attaque du sbire.");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("VOUS ÊTES MORT !");  
                                }

                            }
                            else if(choix==2)
                            {
                                Console.Clear();
                                Console.WriteLine("Une fois arrivé a l'antre de Zorlax vous tirer une flèche sur lui et lorsqu'il se retourne vous tentez de faire une roulade vers la gauche mais dû a votre manque d'agilité celui-ci vous enfonca sa queue en lame dans la gorge et vous mourrez d'un seul coup.");
                                System.Threading.Thread.Sleep(6500);
                                Console.WriteLine("VOUS ÊTES MORT !");
                            }
                        }
                    }

                }
                else if(choix==2)
                {
                    Console.Clear();
                    Console.WriteLine("Vous partez vers la plaine et lors du trajet tout est calme ,mais soudainement une plante tente de vous aggriper la jambe mais grâce a votre agilité vous esquiver son attaque et vous rendez a O'rgamil.");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("Une fois rendu a O'rgamil, un être sournois vous arrêta et vous proposa un marché.");
                    System.Threading.Thread.Sleep(2500);
                    Console.WriteLine("Il vous emmena dans une maison sombre et en fais celui-ci est un maître voleur et vous demande de devenir son apprenti sans hésiter vous dites oui et il consuma une partie de votre âme pour l'engagement .");
                    System.Threading.Thread.Sleep(3500);
                    Console.WriteLine("Il vous a volé 1 point de vie donc il vous reste 4 point de vie ,mais l'entrainement commence.");
                    System.Threading.Thread.Sleep(2500);
                    Console.WriteLine("Une dague à la main vous apprenez des techniques sournoises discrètes et très efficaces.");
                    System.Threading.Thread.Sleep(2500);
                    Console.WriteLine("Après cet entrainement intense vous avez le choix de continuer à vous entrainer pour pouvoir utiliser un enchantement de poison sur votre dague et de maitriser les couteaux de lancer pour distraire l'ennemi ou bien de partir vaincre Zorlax!");
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("1- Continuer entrainement");
                    Console.WriteLine("2- Aller vaincre Zorlax");
                    choix = Convert.ToInt32(Console.ReadLine());
                    if(choix==1)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous commencez l'entrainement avec les dagues empoisonnés.Vous faites un faux mouvement et vous coupez le bras avec votre dague,heureusement le maitre voleur a immédiatement sorti son remède contre le poison mais vous avez tout de même perdu 1 point de vie.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("Il vous reste 3 points de vie!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Vous arrivez a la fin de l'entrainement et vous obtenez une dague empoisonné et quelque couteau de lancer. Félicitation!");
                        System.Threading.Thread.Sleep(3500);
                        Console.WriteLine("Une fois prêt vous partez vers l'antre de Zorlax ,mais en chemin vous tombez sur un ours zombie.");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("Vous lui lancez un couteau de lancer droit dans l'oeil ce qui le déstabilise durant quelque seconde vous en profiter pour l'attaquer droit dans le coeur,mais au même moment il vous graffigna d'un coup de patte ce qui vous enleva 1 point de vie.");
                        System.Threading.Thread.Sleep(3500);
                        Console.WriteLine("Il vous reste 2 point de vie!");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Vous arrivez a l'antre de Zorlax et lui lancer un couteau de lancer pour le distraire et allez vous cacher directement derrière un rocher.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("Vous devez choisir entre attendre qu'il se retourne dos a vous ou tenter une attaque surprise par devant.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("1- Attendre");
                        Console.WriteLine("2- Attaquer");
                        choix = Convert.ToInt32(Console.ReadLine());
                        if(choix==1)
                        {
                            Console.Clear();
                            Console.WriteLine("Une fois que le monstre crois qu'il n'a plus rien a craindre et se retourna dos a vous vous profitez de l'occasion pour lui donné un coup de dague dans le dos ce qui l'empoisonna.");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("Vous partez de l'antre et le monstre légendaire mourra empoisonné quelques heures apres l'attaque.");
                            System.Threading.Thread.Sleep(3500);
                            Console.WriteLine("Félicitations, vous avez réussi a remmettre l'ordre dans le royaume !");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("Vous avez passé le jeu!!");
                        }
                        else if(choix ==2)
                        {
                            Console.Clear();
                            Console.WriteLine("Lors de votre saut pour planter votre dague dans la tête de Zorlax il vous attrapa en plein vol et fesa qu'une bouchée de vous.");
                            System.Threading.Thread.Sleep(3500);
                            Console.WriteLine("VOUS ÊTES MORT !");
                        }
                    }
                    else if (choix==2)
                    {
                        Console.Clear();
                        Console.WriteLine("Vous partez vers l'antre de Zorlax mais croisez un ours zombie en chemin celui-ci courra a toute vitesse vers vous.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("Vous avez 1 chance sur 2 d'esquiver sa morsure mortelle!");
                        Random generateurNb = new Random();
                        nb = (int)generateurNb.Next(1, 11);
                        if(nb <=5)
                        {
                            Console.Clear();
                            Console.WriteLine("L'ours reussissa a vous mordre et ce qui vous affaiblissa et commenca a vous dévorer.");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("VOUS ÊTES MORT !");
                        }
                        else if (nb>=6)
                        {
                            Console.Clear();
                            Console.WriteLine("Vous esquivez sa morsure et le poignardez dans la tête ,vous vous précipitez vers l'antre de Zorlax");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("Vous allez donner un coup de dague furtivement dans le dos de Zorlax mais votre dague n'a aucune effet sur lui car sa peau est trop épaisse il vous aurais fallu une dague empoisonné .");
                            System.Threading.Thread.Sleep(3500);
                            Console.WriteLine("Il se retourna et ne fit qu'une bouchée de vous. ");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("VOUS ÊTES MORT !");

                        }
                    }
                } 
            }
        }

      
    }
 }
