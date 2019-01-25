import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.Random;

public class Shark extends Fish implements Serializable {
	@Override
	public int GetAge() {
		return super.GetAge();
	}


	protected void SetAge(int value) {
		if (value > 0 && value < 30) {
			super.SetAge(value);
		} else {
			super.SetAge(20);
		}
	}

	@Override
	public double GetSpeed() {

		return super.GetSpeed();
	}

	@Override
	protected void SetSpeed(int value) {
		if (value > 0 && value < 50) {
			super.SetSpeed(value);
		} else {
			super.SetSpeed(30);
		}
	}

	@Override
	public int GetWeight() {
		return super.GetWeight();
	}

	@Override
	protected void SetWeight(int value) {
		if (value > 0 && value < 30) {
			super.SetWeight(value);
		} else {
			super.SetWeight(25);
		}
	}

	public Shark(int speed, int age, int weight, Color color) {
		this.SetSpeed(speed);
		this.SetAge(age);
		this.SetColorBody(color);
		this.SetWeight(weight);
		Random rand = new Random();
		startPosX = rand.nextInt(600);
		startPosY = rand.nextInt(300);
	}

	protected void draw1Shark(Graphics g) {

		g.setColor(GetColorBody());

		// Body
		g.drawLine(startPosX, startPosY, startPosX + GetAge() * 3, startPosY
				- GetWeight());
		g.drawLine(startPosX + GetAge() * 3, startPosY - GetWeight(), startPosX
				+ GetAge() * 9, startPosY);
		g.drawLine(startPosX, startPosY, startPosX + GetAge() * 3, startPosY
				+ GetWeight());
		g.drawLine(startPosX + GetAge() * 3, startPosY + GetWeight(), startPosX
				+ GetAge() * 9, startPosY);

		// Fin
		g.drawLine(startPosX + GetAge() * 3, startPosY - GetWeight(), startPosX
				+ GetAge() * 6, startPosY - GetWeight() * 2);
		g.drawLine(startPosX + GetAge() * 6, startPosY - GetWeight() * 2,
				startPosX + GetAge() * 6, startPosY - GetWeight() / 2);

		// Tail
		g.drawLine(startPosX + GetAge() * 9, startPosY, startPosX + GetAge()
				* 11, startPosY + GetWeight());
		g.drawLine(startPosX + GetAge() * 9, startPosY, startPosX + GetAge()
				* 11, startPosY - GetWeight());
		g.drawLine(startPosX + GetAge() * 11, startPosY + GetWeight(),
				startPosX + GetAge() * 10, startPosY);
		g.drawLine(startPosX + GetAge() * 11, startPosY - GetWeight(),
				startPosX + GetAge() * 10, startPosY);

	}

	@Override
	public void drawAnimal(Graphics g) {
		// TODO Auto-generated method stub
		draw1Shark(g);
	}

	@Override
	public void moveAnimal(Graphics g) {
		// TODO Auto-generated method stub
		startPosX -= (GetSpeed());
		drawAnimal(g);
	}
}
