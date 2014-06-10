import java.awt.*;
import java.awt.event.KeyEvent;
import java.awt.image.BufferedImage;
import java.util.Random;
import java.util.TimerTask;
import javax.swing.JFrame;
import java.util.Timer;
import java.util.concurrent.CountDownLatch;

/**
 * Main class for the game
 */
@SuppressWarnings("serial")
public class Frogger extends JFrame {
	boolean isRunning = true;
	boolean isOnLog = false;
	boolean isInRiver = false;
	static int fps = 50;// 30 //50
	static int windowWidth = 800;
	static int windowHeight = 650;
	static int deadtime;
	static int lives = 3;
	static int score = 0;
	static Timer timer;
	static Timer timer2;
	static int delay = 1000;
	static int period = 1000;
	static long movetimer;
	static int interval;
	static int interval2;
	static boolean death = false;
	static Random rnd = new Random();
	BufferedImage backBuffer;
	Insets insets;
	InputHandler input;
	static String str = new String("up");

	static int[][][] cars = new int[4][6][4];
	static int[][][] logs = new int[4][6][4];
	long[] carSpawnTime = new long[4];
	long[] logSpawnTime = new long[4];
	// Load static graphics
	Image road = Toolkit.getDefaultToolkit().getImage("Images/rroad.png");
	Image water = Toolkit.getDefaultToolkit().getImage("Images/vodu.png");
	Image player = Toolkit.getDefaultToolkit().getImage("Images/toad.png");
	Image playerL = Toolkit.getDefaultToolkit().getImage("Images/toadL.png");
	Image playerR = Toolkit.getDefaultToolkit().getImage("Images/toadR.png");
	Image playerD = Toolkit.getDefaultToolkit().getImage("Images/toadD.png");
	Image car1 = Toolkit.getDefaultToolkit().getImage("Images/car1.png");
	Image car2 = Toolkit.getDefaultToolkit().getImage("Images/car2.png");
	Image car3 = Toolkit.getDefaultToolkit().getImage("Images/car3.png");
	Image car1r = Toolkit.getDefaultToolkit().getImage("Images/car1r.png");
	Image car2r = Toolkit.getDefaultToolkit().getImage("Images/car2r.png");
	Image car3r = Toolkit.getDefaultToolkit().getImage("Images/car3r.png");
	Image pave = Toolkit.getDefaultToolkit().getImage("Images/pave1.png");
	Image grass = Toolkit.getDefaultToolkit().getImage("Images/grass.png");
	Image scoreBoard = Toolkit.getDefaultToolkit().getImage("Images/score.png");
	Image log1 = Toolkit.getDefaultToolkit().getImage("Images/durvo1.png");
	Image log2 = Toolkit.getDefaultToolkit().getImage("Images/durvo1.png");
	Image turtle = Toolkit.getDefaultToolkit().getImage("Images/turtles.png");
	Image turtler = Toolkit.getDefaultToolkit().getImage("Images/turtlesr.png");
	Image dead = Toolkit.getDefaultToolkit().getImage("Images/DIE/DIE0006.png");
	Image dead2 = Toolkit.getDefaultToolkit().getImage("Images/cop.png");
	int x = windowWidth / 2 - 40;// 960
	int y = windowHeight - 48;// 1000

	public static void main(String[] args) {
		Frogger game = new Frogger();
		int carY = windowHeight - 100;
		// FILL CARS
		for (int[][] lane : cars) {
			for (int[] car : lane) {
				car[1] = carY;
				car[2] = rnd.nextInt(4);
				car[3] = 1;
				if (carY == windowHeight - 100 || carY == windowHeight - 200) {
					car[0] = windowWidth + 100;
				} else {
					car[0] -= 100;
				}
			}
			carY -= 50;
		}
		carY -= windowHeight - 550;
		// FILL LOGS
		for (int[][] lane : logs) {
			for (int[] log : lane) {
				log[1] = carY;
				log[2] = rnd.nextInt(4);
				log[3] = 1;
				if (carY == windowHeight - 550 || carY == windowHeight - 650) {
					log[0] = windowWidth + 300;
				} else {
					log[0] -= 300;
				}
			}
			carY -= 50;
		}
		game.run();
		System.exit(0);
	}

	public void run() {
		while (true) {
			initialize();
			time();
			while (isRunning) {
				
				long time = System.currentTimeMillis();

				update();
				draw();
				if (lives == 0) {
					loss();

				}
				if (interval == 0) {
					lives = lives - 1;
					x = windowWidth / 2 - 40;
					y = windowHeight - 48;
					interval = 60;
					interval2 = 4;
				}
				if (interval2 <= 0) {
					death = false;
					x = windowWidth / 2 - 40;
					y = windowHeight - 48;
					interval = 60;
					interval2 = 4;
					str = "up";
				}
				// delay for each frame - time it took for one frame
				time = (1000 / fps) - (System.currentTimeMillis() - time);
				if (time > 0) {
					try {
						Thread.sleep(time);
					} catch (Exception e) {
					}
				}

			}
			timer.cancel();
			timer.purge();
			setVisible(false);
		}

	}

	void initialize() {
		setTitle("Frogger");
		setSize(windowWidth, windowHeight);
		setResizable(false);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setVisible(true);

		insets = getInsets();
		setSize(insets.left + windowWidth + insets.right, insets.top
				+ windowHeight + insets.bottom);

		backBuffer = new BufferedImage(windowWidth, windowHeight,
				BufferedImage.TYPE_INT_RGB);
		input = new InputHandler(this);

	}

	void update() {
		if (y <= 300 && y > 105) {
			isInRiver = true;
		} else {
			isInRiver = false;
		}

		// UPDATE CARS
		int currentLane = -1;
		for (int[][] lane : cars) {
			currentLane++;
			for (int[] car : lane) {
				if (car[0] == windowWidth + 100 || car[0] == -100) {
					if (System.currentTimeMillis() - carSpawnTime[currentLane] > 800) {
						car[3] = rnd.nextInt(100);
						carSpawnTime[currentLane] = System.currentTimeMillis();
					}
				}
			}
		}
		// UPDATE LOGS
		currentLane = -1;
		for (int[][] lane : logs) {
			currentLane++;
			for (int[] log : lane) {
				if (log[0] == windowWidth + 300 || log[0] == -300) {
					if (System.currentTimeMillis() - logSpawnTime[currentLane] > 3000) {
						log[3] = rnd.nextInt(100);
						logSpawnTime[currentLane] = System.currentTimeMillis();
					}
				}
			}
		}

		// Movement
		if (!death) {
			long newTimer = System.currentTimeMillis();
			if (y >= 99) {
				if (newTimer - movetimer >= 200) {
					if (input.isKeyDown(KeyEvent.VK_RIGHT)) {
						if (x < windowWidth - 50) {
							str = "right";
							SoundEffects.jump();
							for (int i = 0; i < 50; i++) {
								x += 1;
							}
							movetimer = System.currentTimeMillis();
						}
					} else if (input.isKeyDown(KeyEvent.VK_LEFT)) {
						if (x > 50) {
							str = "left";
							SoundEffects.jump();
							for (int i = 0; i < 50; i++) {
								x -= 1;
							}
							movetimer = System.currentTimeMillis();
						}
					} else if (input.isKeyDown(KeyEvent.VK_UP)) {
						str = "up";
						SoundEffects.jump();
						for (int i = 0; i < 50; i++) {
							y -= 1;
						}
						movetimer = System.currentTimeMillis();
					} else if (input.isKeyDown(KeyEvent.VK_DOWN)) {
						if (y < windowHeight - 50) {
							str = "down";
							SoundEffects.jump();
							for (int i = 0; i < 50; i++) {
								y += 1;
								isInRiver = false;
							}
							movetimer = System.currentTimeMillis();
						}
					}

				}
			} else if (y < 99) {
				Win();
			}
		}
	}

	void draw() {
		Graphics g = getGraphics();
		Graphics bbg = backBuffer.getGraphics();
		Graphics2D ga = (Graphics2D) bbg;

		bbg.setColor(Color.WHITE);
		bbg.fillRect(0, 0, windowWidth, windowHeight);
		bbg.setColor(Color.BLACK);
		// LEVEL and PLAYER
		bbg.drawImage(road, 0, 400, this);
		bbg.drawImage(grass, 0, 300, this);
		bbg.drawImage(grass, 0, 50, this);
		bbg.drawImage(pave, 0, 350, this);
		bbg.drawImage(water, 0, 100, this);
		bbg.drawImage(scoreBoard, 0, 0, this);
		bbg.drawImage(pave, 0, windowHeight - 50, this);
		ga.setPaint(Color.black);
		ga.fillRect(interval * 3 + 310, 2, 180 - interval * 3, 40);
		if (lives == 2) {
			ga.fillRect(742, 2, 45, 45);
		}
		if (lives == 1) {
			ga.fillRect(698, 2, 90, 45);
		}
		// LOGS
		isOnLog = false;
		if (str.equals("drown")) {
			bbg.drawImage(dead2, x, y, this);
		}
		for (int[][] lane : logs) {
			for (int[] log : lane) {
				if (log[3] % 2 == 0) {
					if (log[2] == 1) {
						bbg.drawImage(log1, log[0], log[1], this);
					} else if (log[2] == 2) {
						bbg.drawImage(log2, log[0], log[1], this);
					} else if (log[2] == 3) {
						if (log[1] == windowHeight - 400
								|| log[1] == windowHeight - 500) {
							bbg.drawImage(turtle, log[0], log[1], this);
						} else {
							bbg.drawImage(turtler, log[0], log[1], this);
						}
					} else if (log[2] == 0) {
						if (log[1] == windowHeight - 400
								|| log[1] == windowHeight - 500) {
							bbg.drawImage(turtle, log[0], log[1], this);
						} else {
							bbg.drawImage(turtler, log[0], log[1], this);
						}
					}
					if (log[1] == windowHeight - 400
							|| log[1] == windowHeight - 500) {
						log[0] -= 2;
						if (log[0] <= -300) {
							log[3] = 1;
							log[0] = windowWidth + 300;
						}
					} else {
						log[0] += 2;
						if (log[0] >= windowWidth + 100) {
							log[3] = 1;
							log[0] = -300;
						}
					}
					// Collision Detection LOGS
					if (!death) {
						if (y >= log[1] && y < log[1] + 50) {
							if (log[2] == 1 || log[2] == 2) {
								if (x > log[0] && x < log[0] + 175) {
									isOnLog = true;
									int oldx = x - log[0];
									if (log[1] == windowHeight - 400
											|| log[1] == windowHeight - 500) {
										oldx -= 2;
									} else {
										oldx += 2;
									}
									y = log[1] + 5;
									x = log[0] + oldx;
								}
							} else if (log[2] == 3 || log[2] == 0) {
								if (x > log[0] && x < log[0] + 225) {
									isOnLog = true;
									int oldx = x - log[0];
									if (log[1] == windowHeight - 400
											|| log[1] == windowHeight - 500) {
										oldx -= 2;
									} else {
										oldx += 2;
									}
									y = log[1] + 5;
									x = log[0] + oldx;
								}
							}
						}
					}
				}
			}
		}
		if (!death) {
			if (isInRiver && !isOnLog) {
				SoundEffects.splash();
				str = "drown";
				Die();
			}
		}
		if(!str.equals("drown")){
		if (str.equals("up")) {
			bbg.drawImage(player, x, y, this);
		} else if (str.equals("left")) {
			bbg.drawImage(playerL, x, y, this);
		} else if (str.equals("right")) {
			bbg.drawImage(playerR, x, y, this);
		} else if (str.equals("down")) {
			bbg.drawImage(playerD, x, y, this);
		} else if (str.equals("drown")) {
			bbg.drawImage(dead2, x, y, this);
		} else if (str.equals("hit")) {
			bbg.drawImage(dead, x, y, this);
		}
		}

		String sc = String.format("%s", String.valueOf(score));
		String tt = String.format("%s", String.valueOf(interval2));
		bbg.setColor(Color.WHITE);
		bbg.setFont(new Font("Jokerman", Font.PLAIN, 27));
		bbg.drawString(sc, 150, 37);
		if(!tt.equals("4") && !tt.equals("0")){
		bbg.setFont(new Font("Jokerman", Font.PLAIN, 180));
		bbg.drawString(tt, windowWidth/2-60, windowHeight/2+80);}

		// Cars
		for (int[][] lane : cars) {
			for (int[] car : lane) {
				if (car[3] % 2 == 0) {
					// COLLISION DETECTION CARS

					Rectangle carRectangle = new Rectangle(car[0], car[1], 100,
							50);
					Rectangle playerRectangle = new Rectangle(x + 5, y + 5, 40,
							40);
					if (!death) {
						if (playerRectangle.intersects(carRectangle)) {
							SoundEffects.hitByCar();
							str = "hit";
							Die();

						}
					}
					if (car[2] == 1) {
						if (car[1] == windowHeight - 100
								|| car[1] == windowHeight - 200) {
							bbg.drawImage(car1, car[0], car[1], this);
						} else {
							bbg.drawImage(car1r, car[0], car[1], this);
						}
					} else if (car[2] == 2) {
						if (car[1] == windowHeight - 100
								|| car[1] == windowHeight - 200) {
							bbg.drawImage(car2, car[0], car[1], this);
						} else {
							bbg.drawImage(car2r, car[0], car[1], this);
						}
					} else if (car[2] == 3) {
						if (car[1] == windowHeight - 100
								|| car[1] == windowHeight - 200) {
							bbg.drawImage(car3, car[0], car[1], this);
						} else {
							bbg.drawImage(car3r, car[0], car[1], this);
						}
					} else if (car[2] == 0) {
						if (car[1] == windowHeight - 100
								|| car[1] == windowHeight - 200) {
							bbg.drawImage(car1, car[0], car[1], this);
						} else {
							bbg.drawImage(car1r, car[0], car[1], this);
						}
					}
					if (car[1] == windowHeight - 100
							|| car[1] == windowHeight - 200) {
						car[0] -= 5;
						if (car[0] <= -100) {
							car[3] = 1;
							car[0] = windowWidth + 100;
						}
					} else {
						car[0] += 5;
						if (car[0] >= windowWidth + 100) {
							car[3] = 1;
							car[0] = -100;
						}
					}
				}
			}
		}
		g.drawImage(backBuffer, insets.left, insets.top, this);
	}

	void Die() {

		death = true;
		score = score + interval;
		lives = lives - 1;

	}

	void Win() {
		score = score + interval * lives;
		x = windowWidth / 2 - 40;
		y = windowHeight - 48;
		interval = 60;
	}

	void StartOver() {
		lives = 3;
		score = 0;
		x = windowWidth / 2 - 40;
		y = windowHeight - 48;
		interval = 60;
	}

	void loss() {
		death = false;
		str = "up";
		// TODO Finish it!
		SoundEffects.gameOver();
		Graphics l = getGraphics();
		Graphics text = getGraphics();
		l.setColor(Color.BLACK);
		l.fillRect(0, 0, windowWidth + 50, windowHeight + 50);
		text.setColor(Color.GREEN);
		text.setFont(new Font("Jokerman", Font.PLAIN, 29));
		text.drawString("GAME OVER!", 285, 300);
		text.drawString("Your score is:", 260, 350);
		text.drawString("PRESS ENTER TO START OVER", 175, 450);
		String sc = String.format("%s", String.valueOf(score));
		text.drawString(sc, 465, 350);
		waitForEnter();
		StartOver();

	}

	void time() {

		timer = new Timer();
		timer2 = new Timer();
		interval = 60;
		interval2 = 4;
		timer.scheduleAtFixedRate(new TimerTask() {

			public void run() {
				--interval;

			}
		}, delay, period);

		timer2.scheduleAtFixedRate(new TimerTask() {
			public void run() {
				if (death) {
					--interval2;
				}
			}
		}, delay, period);

	}

	public void waitForEnter() {
		final CountDownLatch latch = new CountDownLatch(1);
		KeyEventDispatcher dispatcher = new KeyEventDispatcher() {
			// Anonymous class invoked from EDT
			public boolean dispatchKeyEvent(KeyEvent e) {
				if (e.getKeyCode() == KeyEvent.VK_ENTER)

					latch.countDown();
				return false;
			}
		};
		KeyboardFocusManager.getCurrentKeyboardFocusManager()
				.addKeyEventDispatcher(dispatcher);
		try {
			latch.await();
		} catch (InterruptedException e1) {
			e1.printStackTrace();
		}
		KeyboardFocusManager.getCurrentKeyboardFocusManager()
				.removeKeyEventDispatcher(dispatcher);
	}
}