import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JCheckBox;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Form {

	private JFrame frame;
	private JTextField FSpeed;
	private JTextField FWeight;
	private JTextField FAge;
	Color color;
	Color dopcolor;
	int speed;
	int weight;
	int age;
	Boolean bands = false;

	private IAnimal inter;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form window = new Form();
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
	public Form() {
		color = Color.WHITE;
		dopcolor = Color.YELLOW;
		speed = 35;
		age = 18;
		weight = 500;
		initialize();

	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 944, 503);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new JPanel();
		panel.setBounds(0, 0, 897, 325);
		frame.getContentPane().add(panel);

		FSpeed = new JTextField();
		FSpeed.setBounds(83, 354, 116, 22);
		frame.getContentPane().add(FSpeed);
		FSpeed.setColumns(10);

		JLabel lblSpeed = new JLabel("Speed");
		lblSpeed.setBounds(15, 357, 56, 16);
		frame.getContentPane().add(lblSpeed);

		JLabel lblWeight = new JLabel("Weight");
		lblWeight.setBounds(15, 386, 56, 16);
		frame.getContentPane().add(lblWeight);

		FWeight = new JTextField();
		FWeight.setBounds(83, 383, 116, 22);
		frame.getContentPane().add(FWeight);
		FWeight.setColumns(10);

		JLabel lblAge = new JLabel("Age");
		lblAge.setBounds(15, 415, 56, 16);
		frame.getContentPane().add(lblAge);

		FAge = new JTextField();
		FAge.setBounds(83, 412, 116, 22);
		frame.getContentPane().add(FAge);
		FAge.setColumns(10);

		JButton FColor = new JButton("Color");
		FColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color initialBackground = FColor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					FColor.setForeground(foreground);
				}
				color = foreground;
			}
		});
		FColor.setBounds(244, 382, 97, 25);
		frame.getContentPane().add(FColor);

		JButton FDopColor = new JButton("DopColor");
		FDopColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = FDopColor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					FDopColor.setForeground(foreground);
				}
				dopcolor = foreground;

			}
		});
		FDopColor.setBounds(550, 411, 97, 25);
		frame.getContentPane().add(FDopColor);

		JCheckBox FBands = new JCheckBox("Bands");
		FBands.setBounds(553, 353, 113, 25);
		frame.getContentPane().add(FBands);

		JButton FShark = new JButton("Create Shark");
		FShark.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					inter = new Shark(speed, age, weight, color);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawAnimal(gr);

				}
			}
		});
		FShark.setBounds(387, 382, 97, 25);
		frame.getContentPane().add(FShark);

		JButton FTShark = new JButton("Create TigerShark");
		FTShark.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					bands = FBands.isSelected();
					inter = new TigerShark(speed, age, weight, color, bands,
							dopcolor);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawAnimal(gr);

				}
			}
		});
		FTShark.setBounds(693, 382, 97, 25);
		frame.getContentPane().add(FTShark);

		JButton FMove = new JButton("Move");
		FMove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (inter != null) {
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.moveAnimal(gr);
				}
			}
		});
		FMove.setBounds(817, 382, 97, 25);
		frame.getContentPane().add(FMove);
	}

	private static boolean isDigit(String s) throws NumberFormatException {
		try {
			Integer.parseInt(s);
			return true;
		} catch (NumberFormatException e) {
			return false;
		}
	}

	private boolean checkFields() {
		if (isDigit(FSpeed.getText())) {
			speed = Integer.parseInt(FSpeed.getText());
		}

		if (isDigit(FAge.getText())) {
			age = Integer.parseInt(FAge.getText());
		}

		if (isDigit(FWeight.getText())) {
			weight = Integer.parseInt(FWeight.getText());
		}

		if (isDigit(FSpeed.getText())) {
			speed = Integer.parseInt(FSpeed.getText());
		}
		return true;
	}
}
