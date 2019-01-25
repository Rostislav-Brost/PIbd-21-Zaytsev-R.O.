import java.awt.Color;
import java.awt.Graphics;

public interface IAnimal {
	void moveAnimal(Graphics g);

	void drawAnimal(Graphics g);

	void setPos(int x, int y);

	void grow(int a);
	void setMainColor(Color color);
}
