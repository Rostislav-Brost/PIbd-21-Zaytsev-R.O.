import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class TigerShark extends Shark implements Serializable {

	private boolean bands;
	private Color dopColor;

	public TigerShark(int speed, int Age, int weight, Color color,
			boolean bands, Color dopColor) {
		super(speed, Age, weight, color);

		this.bands = bands;
		this.dopColor = dopColor;
	}

	public void setDopColor(Color color) {
		dopColor = color;
	}

	public Color GetDopColor() {
		return dopColor;
	}

	@Override
	protected void draw1Shark(Graphics g) {
		super.draw1Shark(g);
		if (bands) {
			g.setColor(dopColor);

			g.drawLine(startPosX + GetAge() * 3, startPosY - GetWeight(),
					startPosX + GetAge() * 4, startPosY);
			g.drawLine(startPosX + GetAge() * 6, startPosY - GetWeight() / 2,
					startPosX + GetAge() * 7, startPosY);
		}
	}
}
