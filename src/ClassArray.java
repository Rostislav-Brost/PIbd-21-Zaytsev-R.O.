class ClassArray<T> {
	private T IAnimal;
	private IAnimal[] cells;

	private IAnimal defaultValue;

	public ClassArray(int size, IAnimal defVal) {
		defaultValue = defVal;
		cells = new IAnimal[size];
		for (int i = 0; i < cells.length; i++) {
			cells[i] = defaultValue;
		}
	}

	public static int Plus(ClassArray<IAnimal> c, IAnimal shark) {
		for (int i = 0; i < c.cells.length; i++) {
			if (c.ChekFreeCell(i)) {
				c.cells[i] = shark;
				return i;
			}
		}
		return -1;
	}

	public static IAnimal Minus(ClassArray<IAnimal> c, int index) {
		if (!c.ChekFreeCell(index)) {
			IAnimal shark = c.cells[index];
			c.cells[index] = c.defaultValue;
			return shark;
		}
		return c.defaultValue;
	}

	private boolean ChekFreeCell(int index) {
		if (index < 0 || index > cells.length) {
			return false;
		}
		if (cells[index] == null) {
			return true;
		}
		if (cells[index].equals(defaultValue)) {
			return true;
		}
		return false;
	}

	public IAnimal getObject(int ind) {
		if (ind > -1 && ind < cells.length) {
			return cells[ind];
		}
		return defaultValue;
	}
}