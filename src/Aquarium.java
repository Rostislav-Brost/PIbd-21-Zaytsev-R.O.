import java.awt.Color;
import java.awt.Graphics;

public class Aquarium {

	ClassArray<IAnimal> aquarium;
	int countCell = 10;
	int cellW = 310;
	int cellH = 80;

	public Aquarium() {
		aquarium = new ClassArray<IAnimal>(countCell, null);
	}

	public int PutSharkInAquarium(IAnimal shark) {
		return aquarium.Plus(aquarium, shark);
	}

	public IAnimal GetSharkinAquarium(int ticket) {
		return aquarium.Minus(aquarium, ticket);
	}

	public void Draw(Graphics g, int w, int h) {
		DrawCells(g);
		for (int i = 0; i < countCell; i++) {
			IAnimal shark = aquarium.getObject(i);
			if (shark != null) {
				shark.setPos(5 + i / 5 * cellW + 100, i % 5 * cellH + 40);
				shark.drawAnimal(g);
			}
		}
	}

	private void DrawCells(Graphics g) {
		g.setColor(Color.BLACK);

		for (int i = 0; i < countCell / 5; i++) {
			for (int j = 0; j < 6; ++j) {
				g.drawLine(i * cellW, j * cellH, i * cellW + 310, j * cellH);
				g.drawLine(i * cellW, j * cellH, i * cellW, j * cellH + cellH);
			}
		}
	}
}
