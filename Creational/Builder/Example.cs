class Trial
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}

class TrialBuilder
{
    private Trial _trial = new Trial();

    public TrialBuilder Reset()
    {
        _trial = new Trial();
        return this;
    }

    public TrialBuilder AddDateRange(DateTime start, DateTime end)
    {
        _trial.Start = start;
        _trial.End = end;
        return this;
    }

    public TrialBuilder AddName(string name)
    {
        _trial.Name = name;
        return this;
    }

    public TrialBuilder AddTitle(string title)
    {
        _trial.Title = title;
        return this;
    }

    public TrialBuilder AddDescription(string description)
    {
        _trial.Description = description;
        return this;
    }

    public Trial Build() => _trial;
}

class TrialDirector
{
    private readonly TrialBuilder _builder;
    
    // Can use interface of builder for bettern testablity
    public TrialDirector(TrialBuilder builder)
    {
        _builder = builder;
    }
    
    public Trial BuildOneYearTrial()
    {
        return _builder
            .Reset()
            .AddDateRange(DateTime.UtcNow, DateTime.UtcNow.AddMonths(12))
            .AddTitle("1-Year Trial")
            .AddDescription("A full one-year trial.")
            .Build();
    }
}