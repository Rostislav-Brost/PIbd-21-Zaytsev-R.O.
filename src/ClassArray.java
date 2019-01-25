import java.io.Serializable;
import java.util.Dictionary;
import java.util.Hashtable;

class ClassArray<T> implements Serializable {
	private T IAnimal;
	// private IAnimal[] cells;
	// 4
	private Dictionary<Integer, T> cells;
	private int maxCount;
	//
	private T defaultValue;
	public ClassArray(int size, T defVal) {
		defaultValue = defVal;
		// 4
		cells = new Hashtable<Integer, T>();
		maxCount = size;
		//
	}

	public static int Plus(ClassArray<IAnimal> c, IAnimal shark) throws AquOverflowException {
		// 4
		if (c.cells.size() == c.maxCount) {
			 throw new AquOverflowException();
		}
		//
		for (int i = 0; i < c.cells.size(); i++) {
			if (c.ChekFreeCell(i)) {
				// 4
				c.cells.put(i, shark);
				//
				return i;
			}
		}
		// 4
		c.cells.put(c.cells.size(), shark);
		return c.cells.size() - 1;
		//
	}

	public static IAnimal Minus(ClassArray<IAnimal> c, int index) throws AquIndexOutOfRangeException {
		// 4
		if (c.cells.get(index) != null) {
			IAnimal shark = c.cells.get(index);
			c.cells.remove(index);
			return shark;
		}
		//
		throw new AquIndexOutOfRangeException();
	}

	private boolean ChekFreeCell(int index) {
		// 4
		return cells.get(index) == null;
		//
	}

	public T getObject(int ind) {
		if (ind > -1 && ind < cells.size()) {
			return cells.get(ind);
		}
		return defaultValue;
	}
}