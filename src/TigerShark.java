import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class TigerShark extends Shark implements Serializable
		 {

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

	public int CompareTo(TigerShark other) {
		int res = ((Shark) this).compareTo((Shark) other);
		if (res != 0) {
			return res;
		}
		if (bands != other.bands) {
			return ("" + bands).compareTo("" + other.bands);
		}
		if (GetColorBody() != other.GetColorBody()) {
			GetColorBody().toString()
					.compareTo(other.GetColorBody().toString());
		}
		if (GetDopColor() != other.GetDopColor()) {
			GetDopColor().toString().compareTo(other.GetDopColor().toString());
		}
		return 0;
	}

	public boolean equals(TigerShark other) {
		boolean res = ((Shark) this).equals((Shark) other);
		if (!res) {
			return res;
		}
		if (bands != other.bands) {
			return false;
		}
		if (dopColor != other.dopColor) {
			return false;
		}
		if (GetColorBody() != other.GetColorBody()) {
			return false;
		}
		return true;
	}

	@Override
	public boolean equals(Object obj) {
		if (obj == null) {
			return false;
		}
		TigerShark sharkObj = (TigerShark) obj;
		if (sharkObj == null) {
			return false;
		} else {
			return equals(sharkObj);
		}
	}
}
