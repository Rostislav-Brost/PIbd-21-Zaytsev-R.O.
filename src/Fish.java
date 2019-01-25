import java.awt.Color;
import java.awt.Graphics;
import java.io.Serializable;

public abstract class Fish implements IAnimal,Serializable{
	protected int startPosX;
	protected int startPosY;

	public abstract void drawAnimal(Graphics g);

	public abstract void moveAnimal(Graphics g);

	public void setPos(int x, int y) {
		startPosX = x;
		startPosY = y;
	}

	public void setMainColor(Color color) {
		ColorBody = color;
	}

	protected int age;
	private int Age;

	protected void SetAge(int a) {
		Age = a;
	}

	public int GetAge() {
		return Age;
	}

	public void grow(int a) {
		if (age + a < Age) {
			age++;
		}
	}

	private double Speed;

	protected void SetSpeed(int s) {
		Speed = s;
	}

	public double GetSpeed() {
		return Speed;
	}

	private int Weight;

	protected void SetWeight(int w) {
		Weight = w;
	}

	public int GetWeight() {
		return Weight;
	}

	private Color ColorBody;

	protected void SetColorBody(Color c) {
		ColorBody = c;
	}

	public Color GetColorBody() {
		return ColorBody;
	}

}
