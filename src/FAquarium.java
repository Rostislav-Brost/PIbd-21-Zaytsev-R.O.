import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JTextPane;
import javax.swing.JFormattedTextField;
import javax.swing.JTextField;
import javax.swing.JList;

public class FAquarium {

	private JFrame frame;
	private JTextField FTicket;
	Matcher m;
	Aquarium aquarium;
	Color color;
	Color dopcolor;
	int speed;
	int weight;
	int age;
	Boolean bands = false;
	private IAnimal inter;
	int SelectedIndex;
	String[] data;

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

		JButton FSetShark = new JButton("Set Shark");
		FSetShark.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = FSetShark.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				color = foreground;

				inter = new Shark(15, 15, 15, color);
				int place = aquarium.PutSharkInAquarium(inter);
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);
			}
		});
		FSetShark.setBounds(584, 61, 115, 29);
		frame.getContentPane().add(FSetShark);

		JButton FSetTShark = new JButton("Set Tiger Shark");
		FSetTShark.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Color initialBackground = FSetShark.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				color = foreground;

				Color initialBackground1 = FSetShark.getForeground();
				Color foreground1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground1);
				dopcolor = foreground1;

				inter = new TigerShark(10, 10, 10, color, true, dopcolor);
				int place = aquarium.PutSharkInAquarium(inter);
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);

			}
		});
		FSetTShark.setBounds(745, 61, 163, 29);
		frame.getContentPane().add(FSetTShark);

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
					if (FTicket.getText() != "") {
						IAnimal shark = aquarium.GetSharkinAquarium(Integer
								.parseInt(FTicket.getText()));
						if (shark != null) {
							Graphics gr = FShark.getGraphics();
							gr.clearRect(0, 0, FShark.getWidth(),
									FShark.getHeight());
							shark.setPos(30, 30);
							shark.drawAnimal(gr);
							Draw(panel);
						}
					}
				}
			}
		});
		FGet.setBounds(714, 572, 115, 29);
		frame.getContentPane().add(FGet);

		JButton FStart = new JButton("Start");
		FStart.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Draw(panel);
			}
		});
		FStart.setBounds(627, 16, 115, 29);
		frame.getContentPane().add(FStart);

		JButton buttonUp = new JButton("->");
		buttonUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				aquarium.LevelUp();
				listBoxLevels.setSelectedIndex(aquarium.getCurrentLevel());
				Draw(panel);
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
			}
		});
		buttonDown.setBounds(608, 142, 75, 29);
		frame.getContentPane().add(buttonDown);
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
}
