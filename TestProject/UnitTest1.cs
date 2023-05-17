using YngveHestem.FileTypeInfo;

namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetFileType_One_ByExtension()
    {
        var types = FileTypes.Types.GetByExtension(".mkv");
        Assert.That(types.Count == 1);
        Assert.That(types[0].UTTypes.Contains("org.matroska.mkv"));
        Assert.That(types[0].MimeTypes.Contains("video/x-matroska"));
    }

    [Test]
    public void GetFileType_One_ByMimeType()
    {
        var types = FileTypes.Types.GetByMimeType("video/x-matroska");
        Assert.That(types.Count == 1);
        Assert.That(types[0].UTTypes.Contains("org.matroska.mkv"));
        Assert.That(types[0].Extensions.Contains(".mkv"));
    }

    [Test]
    public void GetFileType_One_ByUTType()
    {
        var types = FileTypes.Types.GetByUTType("org.matroska.mkv");
        Assert.That(types.Count == 1);
        Assert.That(types[0].MimeTypes.Contains("video/x-matroska"));
        Assert.That(types[0].Extensions.Contains(".mkv"));
    }

    [Test]
    public void GetFileType_Multiple_ByOneExtension()
    {
        var types = FileTypes.Types.GetByExtension(".aiff");
        Assert.That(types.Count > 1);
    }

    [Test]
    public void GetFileType_Multiple_ByMultipleExtensions()
    {
        var types = FileTypes.Types.GetByExtension(new string[] { ".mkv", ".java"});
        Assert.That(types.Count > 1);
    }

    [Test]
    public void GetFileType_No_ByExtension()
    {
        var types = FileTypes.Types.GetByExtension(new string[] { ".mycustomextension" });
        Assert.That(types.Count == 0);
    }

    [Test]
    public void GetFileType_GetAllWithChildren_ByUTType()
    {
        var movieTypes = FileTypes.UTTypeParentsList.GetUTTypeChildrenByParent("public.movie");
        Assert.That(movieTypes != null);
        Assert.That(movieTypes.Count, Is.GreaterThan(5));

        var types = FileTypes.Types.GetByUTType(movieTypes);
        Assert.That(types.Count > 5);
        Assert.That(types.Any(t => t.Extensions.Contains(".mkv")));
        Assert.That(types.Any(t => t.Extensions.Contains(".m4v")));
        Assert.That(types.Any(t => t.Extensions.Contains(".mp4")));
    }
}
