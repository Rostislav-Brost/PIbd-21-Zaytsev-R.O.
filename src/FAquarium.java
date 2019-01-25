import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.PrintStream;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.SimpleFormatter;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import javax.swing.JColorChooser;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JTextPane;
import javax.swing.JFormattedTextField;
import javax.swing.JTextField;
import javax.swing.JList;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JMenu;

public class FAquarium {
	FSelectColor window = null;
	static JFrame frame;
	JPanel panel;
	private JTextField FTicket;
	Matcher m;
	static Aquarium aquarium;
	Color color;
	Color dopcolor;
	int speed;
	int weight;
	int age;
	Boolean bands = false;
	private static IAnimal inter;
	int SelectedIndex;
	String[] data;
	static boolean close = false;
	private FileHandler handler = null;
	private java.util.logging.Logger logger = null;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FAquarium window = new FAquarium();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public FAquarium() {
		try {
			handler = new FileHandler("test.log", true);
			handler.setFormatter(new SimpleFormatter());
			logger = java.util.logging.Logger.getLogger("test");
			logger.addHandler(handler);
		} catch (IOException ioe) {
			ioe.printStackTrace();
		}
		color = Color.WHITE;
		dopcolor = Color.YELLOW;
		speed = 35;
		age = 18;
		weight = 500;
		aquarium = new Aquarium(5);
		SelectedIndex = -1;
		data = new String[7];
		for (int i = 0; i < data.length; i++) {
			data[i] = "Level " + i;
		}
		initialize();
	}

	private void Draw(JPanel panel) {
		// 5
		if (close) {
			IAnimal shark = window.getShark();
			if (shark != null) {
				try {
					aquarium.PutSharkInAquarium(shark);
				} catch (AquOverflowException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				panel.repaint();
				JOptionPane.showMessageDialog(frame, "Акула добавлена");

				logger.log(Level.INFO, "PutSharkInAquarium");
				close = false;
			}
		}
		//

		// 4

		if (aquarium.getCurrentLevel() > -1) {
			//
			Graphics gr = panel.getGraphics();
			gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());

			aquarium.Draw(gr, panel.getWidth(), panel.getHeight());
		}
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {

		frame = new JFrame();
		frame.setBounds(100, 100, 970, 689);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new JPanel();
		panel.setBounds(0, 0, 569, 572);
		frame.getContentPane().add(panel);

		JList listBoxLevels = new JList(data);
		listBoxLevels.setBounds(686, 106, 146, 91);
		frame.getContentPane().add(listBoxLevels);
		listBoxLevels.setSelectedIndex(aquarium.getCurrentLevel());

		JLabel Number = new JLabel("Number");
		Number.setBounds(745, 205, 69, 20);
		frame.getContentPane().add(Number);

		FTicket = new JTextField();
		FTicket.setBounds(654, 241, 238, 37);
		frame.getContentPane().add(FTicket);

		JButton btnNewButton = new JButton("\u041E\u041A");
		btnNewButton.setBounds(714, 289, 115, 29);
		frame.getContentPane().add(btnNewButton);

		JPanel FShark = new JPanel();
		FShark.setBounds(654, 336, 227, 220);
		frame.getContentPane().add(FShark);

		JButton FGet = new JButton("Get");
		FGet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				// 4
				if (listBoxLevels.getSelectedIndex() > -1) {
					String level = listBoxLevels.getSelectedValue().toString();
					//
					IAnimal shark = null;
					if (FTicket.getText() != "") {
						try {
							shark = aquarium.GetSharkinAquarium(Integer
									.parseInt(FTicket.getText()));
						} catch (NumberFormatException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						} catch (AquIndexOutOfRangeException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
						if (shark != null) {
							Graphics gr = FShark.getGraphics();
							gr.clearRect(0, 0, FShark.getWidth(),
									FShark.getHeight());
							shark.setPos(30, 30);
							shark.drawAnimal(gr);
							panel.repaint();
						}
					}
				}

				logger.log(
						Level.INFO,
						"GetSharkinAquarium from  "
								+ Integer.parseInt(FTicket.getText()));
			}
		});
		FGet.setBounds(714, 572, 115, 29);
		frame.getContentPane().add(FGet);

		JButton FStart = new JButton("Start");
		FStart.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Draw(panel);
				logger.log(Level.INFO, "Repaint");
			}
		});
		FStart.setBounds(681, 16, 115, 29);
		frame.getContentPane().add(FStart);

		JButton buttonUp = new JButton("->");
		buttonUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				aquarium.LevelUp();
				listBoxLevels.setSelectedIndex(aquarium.getCurrentLevel());
				Draw(panel);
				logger.log(Level.INFO, "LevelUp");
			}
		});
		buttonUp.setBounds(833, 142, 75, 29);
		frame.getContentPane().add(buttonUp);

		JButton buttonDown = new JButton("<-");
		buttonDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				aquarium.LevelDown();
				listBoxLevels.setSelectedIndex(aquarium.getCurrentLevel());
				Draw(panel);
				logger.log(Level.INFO, "LevelDown");
			}
		});
		buttonDown.setBounds(608, 142, 75, 29);
		frame.getContentPane().add(buttonDown);

		// 5
		JButton btnOrder = new JButton("Order");
		btnOrder.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				logger.log(Level.INFO, "Order");
				try {
					frame.setVisible(false);
					window = new FSelectColor();
					window.frame.setVisible(true);

				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
		btnOrder.setBounds(681, 61, 115, 29);
		frame.getContentPane().add(btnOrder);

		JMenuBar menuBar = new JMenuBar();
		frame.setJMenuBar(menuBar);

		JMenu mnFile = new JMenu("File");
		menuBar.add(mnFile);

		JMenuItem mntmSave = new JMenuItem("Save");
		mnFile.add(mntmSave);
		mntmSave.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				JFileChooser save = new JFileChooser();
				if (save.showDialog(null, "Save") == JFileChooser.APPROVE_OPTION) {
					try {
						if (aquarium.Save(save.getSelectedFile().getPath())) {
							if (save.getSelectedFile().getPath() != null) {
								JOptionPane.showMessageDialog(frame, "Save");
								logger.log(Level.INFO, "Save: successfully");
							}
						}
					} catch (IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
						logger.log(Level.INFO, "Save: error " + e1);
					}
				}
			}
		});

		JMenuItem mntmLoad = new JMenuItem("Load");
		mnFile.add(mntmLoad);
		mntmLoad.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				JFileChooser load = new JFileChooser();
				if (load.showDialog(null, "Open") == JFileChooser.APPROVE_OPTION) {
					try {
						if (aquarium.Load(load.getSelectedFile().getPath()))
							if (load.getSelectedFile().getPath() != null)
								JOptionPane.showMessageDialog(frame, "Load");
						logger.log(Level.INFO, "Load: successfully");
					} catch (ClassNotFoundException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
						logger.log(Level.INFO, "Load: error  " + e1);
					} catch (IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
						logger.log(Level.INFO, "Load: error  " + e1);
					}
				}
				Draw(panel);
			}
		});
		//
		btnNewButton.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				Pattern p = Pattern.compile("\\d");
				m = p.matcher(FTicket.getText());
				if (!m.matches()) {
					System.out.println("NO");
					FTicket.setText("");
				} else
					System.out.println("Yes");
			}
		});
	}

	public void AddShark(IAnimal shark) throws AquOverflowException {
		if (shark != null) {
			int place = aquarium.PutSharkInAquarium(shark);
			System.out.println(place);
			if (place > -1) {
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);
			} else {
				JOptionPane.showMessageDialog(frame,
						"акулу не удалось посадить в клетку");
			}
		}
	}
}
