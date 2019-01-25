import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.Random;

public class Shark extends Fish implements Serializable, Comparable<Shark> {
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

	@Override
	public int compareTo(Shark other) {
		// TODO Auto-generated method stub
		if (other == null) {
			return 1;
		}
		if (GetAge() != other.GetAge()) {
			return GetAge()+"".compareTo(Integer.toString(other.GetAge()));
		}
		if (GetSpeed() != other.GetSpeed()) {
			return (int)GetSpeed()+"".compareTo(Double.toString(other.GetSpeed()));
		}
		if (GetWeight() != other.GetWeight() ) {
			return GetWeight()+"".compareTo(Integer.toString(other.GetWeight()) );
		}
		if (GetColorBody() != other.GetColorBody()) {
			return GetColorBody().toString().compareTo(other.GetColorBody().toString());
			
		}
		return 0;
	}
	public boolean equals(Shark other)
	         {
	            if (other == null)
	             {
	                 return false;
	             }
	             if (GetSpeed() != other.GetSpeed())
	             {
	                 return false;
	             }
	             if (GetAge() != other.GetAge())
	             {
	                 return false;
	             }
	             if (GetWeight() != other.GetWeight())
	             {
	                 return false;
	             }
	             if (GetColorBody() != other.GetColorBody())
	             {
	                 return false;
	             }
	             return true;
	         }
	@Override
	         public  boolean equals(Object obj)
	         {
	             if (obj == null)
	             {
	                 return false;
	             }
	             Shark sharkObj = (Shark)obj;
	             if (sharkObj == null)
	             {
	                 return false;
	             }
	             else
	             {
	                 return equals(sharkObj);
	             }
	         }
}
