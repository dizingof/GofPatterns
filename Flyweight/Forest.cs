class Forest
{
    private List<Tree> _trees = new List<Tree>();

    public void PlantTree(int x, int y, string name, string color, string texture)
    {
        var treeType = TreeFactory.GetTreeType(name, color, texture);
        var tree = new Tree(x, y, treeType);
        _trees.Add(tree);
    }

    public void Draw()
    {
        foreach (var tree in _trees)
        {
            tree.Draw();
        }
    }
}