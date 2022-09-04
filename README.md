# Проект по Визуелно програмирање - Car Racing (Документација)
Изработено од Јована Крстевска 173246
## Опис на играта
Car Racinig е спортска и забавна игра каде што претставува тркање со коли. Играчот има целосна контрола врз неговото возило така што го движи со користење на копчињата за лево `(<)` и за десно `(>)`. Со самото движење на возилото подолго време, неговото возило почнува полека да се забрзува така што паралелно се забрзуваат и другите коли. Забрзувањето се случува во зависност од неговиот score односно колку повеќе поени освојува. Целта на оваа игра е играчот да не се удри со некое друго возило и да извади најголем `score`. Со самиот удар со неговото возило, играчот ќе има опција повторно да ја игра играта. 
## Изглед на играта
![MainMenu](https://user-images.githubusercontent.com/100038564/188306006-06d86efa-2555-4c58-931e-08e1d518c282.PNG)<br/>
*Слика 1: Изглед на Main Menu*<br/><br/>
На сликата погоре имаме еден приказ како изгледа Main Menu. Горе лево е копчето `Start` каде што со самото кликање на тоа копче, автоматски ја започнува играта, додека долу десно ги кажува контролите со кој играчот треба да го управува/ракува возилото. Сликата што го опфаќа целиот Main Menu е поставена во `panel` и во делот кај `BackgroundImageLayot` ставено е како `Stretch` за да може да се растегне целата слика. Копчето Start и контролите се ставени во `picture box` секое посебно и сликите се направени да бидат транспаретни со самата позадина.<br/><br/>
![CarRacing](https://user-images.githubusercontent.com/100038564/188306879-082350ef-ac9d-4aec-b2b8-7d5568486a6c.PNG)<br/>
*Слика 2: Изглед на играта*<br/><br/>
На оваа слика што е погоре ја прикажува физуелно играта. Како што можеме да видиме на сликата, имаме три коли каде што портокаловата е возилото на играчот односно `PlayerCar` додека другите две возила се рандом возила и се позиционирани на различни страни. Возилата, лентите и сликата Game Over се ставени како `picture box` додека целиот екран е ставен во `panel`. Подолу на екранот имаме едно копче каде што пишува Play Again. Тоа копче му овозможува на играчот повторно да ја игра играта додека не дојде повторно до Game Over. Исто времено под копчето гледаме дел каде што пишува Score: каде што му кажува на играчот колку поени има освоено во таа рунда.
## Внатрешна структура и функциите на играта
```javascript
        int score;
        int carImage;
        int playerSpeed = 9;
        int trafficSpeed = 5;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;
```
Погоре се деклалирани променливи и методот `Random()` кои ни се потребни за играта. Променливата `Score` враќа вредност каде што кажува колку поени има освоено играчот, променливата `carImage` враќа вредност односно индексот на возилото, променливата `playerSpeed` има зададена вредност по default 9 каде што ја кажува брзината на играчот, променливата `trafficSpeed` по default има вредност 5 ја кажува брзината на другите коли и на крај имаме променливи `goleft` и `goright` каде што тие враќаат true или false каде што ни помагаат за самото движење на играчот. `rand` и `carPosition` се објекти од Random() методот каде што ни даваат рандом вредности во зависност од ситуацијата.<br/>
### 1. Објаснување за патот
Најпрво ќе објасниме како патот има анимација односно како патот се движи напред со помош на функцијата која е дадена подоле. Како што можеме да видиме функцијата `moveLine` прима аргумент `speed` каде што ја дава брзината, по default 5 на лентите и функцијата не враќа никаква вредност. Лентите се направени секое посебно во посебен picture box со бела позадина. Движењето и позиционирањето на лентите се одвиваат по `Y` оска. На почетокот сите ленти се позиционирани најгоре односно со помош на `Top`. Во самиот услов викаме доколку лентата е еднаква или поголема од 500 тогаш викаме дека позицијата на таа лента треба да биде 0 односно кога самата таа лента ќе стидне до крајот на прозорецот, автоматски да се позиционира на почетокот, но додека е помала од 500 тогаш со помош на користиње на speed лентата се движи надолу по Y оска. На овој начин им правиме if statments и на останатите ленти кое како резултат правиме еден циклус односно движење на самиот пат. Лентите кои се позиционирани од страна се оставени по default односно тие немаат никакво движење.<br/>
```javascript
void moveLine(int speed)
        {
            if(pictureBox1.Top>=500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }
  ```
### 2. Движењето на играчот
Движењето на играчот е доста едноставно со тоа што кога играчот ќе држи на копчето лево автоматски неговото возило се движи на лево, додека го држи копчето десно неговото возило се движи на десно. Постојат две функции `Key_Down` и `Key_Up`.
```javascript
private void Key_Down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void Key_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }
```
Подолу што е даден кодот ни претставуваат ѕидови од двете страни на патот. При движење на возилото додека сака играчот до оди до крај на десно или на лево му кажува до каде максимум може да отиде со возилото. Овој код се наоѓа во функцијата gameTimer_Tick.
```javascript
            if(goleft == true && PlayerCar.Left > 20)
            {
                PlayerCar.Left -= playerSpeed;
            }
            if(goright == true && PlayerCar.Left <400)
            {
                PlayerCar.Left += playerSpeed;
            }
```
### 3. Менување автоматски на возилата
Функцијата `changeCars()` претставува функција каде што при секое движење на првите две коли/возила се ресетираат и автоматски се менуваат други две возила со различна позиција. Променливата `carImage` враќа една вредност односно рандом вредност каде што таа вредност се наоѓа во опсегот од 1 до 7 во оваа ситуација. Со помош на switch/case ги листа сите возила кои што се наоѓаат во Resources и со помош на промелнивата која веќе ја чува таа рандом вредност го селектира тоа возило кое е потребно. На пример доколку carImage има вредност 5, во switch ќе оди директно во case 5 и го зима тоа возило каде што на крај го зачува тоа возило во `tempCar`. Откога ќе го направи тоа поставува рандом позиција на тоа возило во зависност од тоа дали се работи за лево возило или десно возило. 
```javascript
private void changeCars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 7);

            switch(carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }

        }
```
Во овој дел се случува промена на возилата односно повикување на changeCars() функцијата и за левото возило и за десното возило. Тие се движаат исто како и возилото на играчот по Y оска и на крај кога ќе стигне до крајот на прозорецот автоматски се повикуваа таа функција и ги бира новите две возила. Последниот if кажува додека возилото на играчот и друго возило се судрат да се повика функцијата gameOver() односно ова се случува додека имаме колизија на две возила.
```javascript
            if(PinkCar.Top>530)
            {
                changeCars(PinkCar);
            }
            if(GreenCar.Top>530)
            {
                changeCars(GreenCar);
            }
            if(PlayerCar.Bounds.IntersectsWith(PinkCar.Bounds) || PlayerCar.Bounds.IntersectsWith(GreenCar.Bounds))
            {
                gameOver();
            }

```
### 4. Имплементација на Score односно поените на играчот
Кодот што е прикажан подолу овозможува зголемување на брзината на возилата `(trafficSpeed)` вклучувајќи го и возилото на играчот `(playerSpeed)` да се зголемува во зависност од поените кои ги добива. На овој начин му станува доста потешко на играчот додека играта станува доста поинтересна.
```javascript
            if(score>40 && score<300)
            {
                over.Image = Properties.Resources.gameover1;
            }
            if(score>300 && score<1500)
            {
                over.Image = Properties.Resources.gameover1;
                trafficSpeed = 11;
                playerSpeed = 10;
            }
            if(score>1500 && score<2500)
            {
                over.Image = Properties.Resources.gameover1;
                trafficSpeed = 13;
                playerSpeed = 12;
            }
            if(score>2500)
            {
                over.Image = Properties.Resources.gameover1;
                trafficSpeed = 15;
                playerSpeed = 14;
            }
```
### 5. gameOver(), ResetGame(), playSound(), backgroundMusic() функции
#### gameOver() функција
```javascript
   private void gameOver()
        {
            playSound();
            gameTimer.Stop();

            over.Visible = true;
            over.BringToFront();

            buttonStart.Enabled = true;
        }
```
#### ResetGame() функција
```javascript
   private void ResetGame()
        {
            backgroundMusic();
            buttonStart.Enabled = false;
            over.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            over.Image = Properties.Resources.gameover1;

            PinkCar.Top = carPosition.Next(300, 650) * -1;
            PinkCar.Left = carPosition.Next(5, 200);

            GreenCar.Top = carPosition.Next(100, 550) * -1;
            GreenCar.Left = carPosition.Next(245, 422);

            gameTimer.Start();
        }
```
#### playSound() и backgroundMusic() фунцкии
```javascript
   private void playSound()
     {
          SoundPlayer playcrash = new SoundPlayer(Properties.Resources.hit);
          playcrash.Play();
     }

   private void backgroundMusic()
     {
          SoundPlayer backgroundmusic = new SoundPlayer(Properties.Resources.backgroundMusic);
          backgroundmusic.Play();
     }
```
