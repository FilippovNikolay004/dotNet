using homework;

TeamLeader teamLeader = new TeamLeader();
Team team = new Team();

teamLeader.Part = team;
teamLeader.BuildFullFeaturedProduct();
Console.WriteLine(team.GetHouse().ListParts());