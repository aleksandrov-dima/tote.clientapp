using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using System;
using Uno.Extensions.Markup;
using Uno.Extensions.Navigation.UI;
using Uno.Material;
using Uno.Toolkit.UI;
using Path = Microsoft.UI.Xaml.Shapes.Path;

namespace ToteClientApp.Presentation;

public partial class MainPage : Page
{
    public MainPage()
    {
        this.DataContext<BindableMainModel>((page, vm) => page
            .Background(Theme.Brushes.Background.Default)
            .NavigationCacheMode(NavigationCacheMode.Required)
            .StatusBar
            (
                s => s
                    .Foreground(StatusBarForegroundTheme.Auto)
                    .Background(Theme.Brushes.Surface.Default)
            )
            .Resources
            (
                r => r
                    .Add("Icon_Icon", "F1 M 9.394393920898438 0.7609653472900391 C 8.411978721618652 -0.2536534070968628 6.784737586975098 -0.25365495681762695 5.802319526672363 0.7609598636627197 L 1.00384521484375 5.71669340133667 C 0.7282613515853882 6.001308917999268 0.5430758893489838 6.361119747161865 0.4716193675994873 6.750794410705566 C -0.11114007234573364 9.928766250610352 -0.15415677428245544 13.182221412658691 0.34437689185142517 16.374488830566406 L 0.5208796858787537 17.50469207763672 C 0.5766286849975586 17.861669540405273 0.8840922713279724 18.124845504760742 1.2453988790512085 18.124845504760742 L 4.598359107971191 18.124845504760742 C 4.874501705169678 18.124845504760742 5.098359107971191 17.90098762512207 5.098359107971191 17.624845504760742 L 5.098359107971191 10.624845504760742 L 10.098359107971191 10.624845504760742 L 10.098359107971191 17.624845504760742 C 10.098359107971191 17.90098762512207 10.322216987609863 18.124845504760742 10.598359107971191 18.124845504760742 L 13.951272964477539 18.124845504760742 C 14.312579154968262 18.124845504760742 14.62004280090332 17.861671447753906 14.675792694091797 17.50469207763672 L 14.852294921875 16.374492645263672 C 15.350828170776367 13.18222427368164 15.307811737060547 9.928764343261719 14.725051879882812 6.750791549682617 C 14.653595924377441 6.361119270324707 14.468411445617676 6.001309871673584 14.192831039428711 5.716695308685303 L 9.394393920898438 0.7609653472900391 Z")
                    .Add("Icon_Search", "F1 M 12.5 11 L 11.710000038146973 11 L 11.430000305175781 10.729999542236328 C 12.410000324249268 9.589999556541443 13 8.110000014305115 13 6.5 C 13 2.9100000858306885 10.089999914169312 0 6.5 0 C 2.9100000858306885 0 0 2.9100000858306885 0 6.5 C 0 10.089999914169312 2.9100000858306885 13 6.5 13 C 8.110000014305115 13 9.589999556541443 12.410000324249268 10.729999542236328 11.430000305175781 L 11 11.710000038146973 L 11 12.5 L 16 17.489999771118164 L 17.489999771118164 16 L 12.5 11 L 12.5 11 Z M 6.5 11 C 4.009999990463257 11 2 8.990000009536743 2 6.5 C 2 4.009999990463257 4.009999990463257 2 6.5 2 C 8.990000009536743 2 11 4.009999990463257 11 6.5 C 11 8.990000009536743 8.990000009536743 11 6.5 11 Z")
                    .Add("Icon_Solid_Status_Book_Open", "F0 M 9.989845275878906 1.489382266998291 C 7.189142227172852 -0.1910395622253418 3.7638763785362244 -0.4654967784881592 0.731329619884491 0.7475219964981079 C 0.2896319031715393 0.9242011308670044 0 1.3519963026046753 0 1.8277196884155273 L 0 13.486600875854492 C 0 14.267565727233887 0.7887605428695679 14.801582336425781 1.5138684511184692 14.511539459228516 C 3.997210144996643 13.518202781677246 6.802148818969727 13.742955207824707 9.095634460449219 15.119046211242676 L 10.230911254882812 15.800212860107422 C 10.317487716674805 15.852158546447754 10.410101890563965 15.87486457824707 10.5 15.873281478881836 C 10.589897155761719 15.87486457824707 10.682513236999512 15.852158546447754 10.769088745117188 15.800212860107422 L 11.904365539550781 15.119046211242676 C 14.197851181030273 13.742955207824707 17.002790451049805 13.518202781677246 19.48613166809082 14.511539459228516 C 20.211238861083984 14.801582336425781 21 14.267565727233887 21 13.486600875854492 L 21 1.8277196884155273 C 21 1.3519963026046753 20.71036720275879 0.9242011308670044 20.2686710357666 0.7475219964981079 C 17.23612403869629 -0.4654967784881592 13.810857772827148 -0.1910395622253418 11.010154724121094 1.489382266998291 L 10.5 1.7954752445220947 L 9.989845275878906 1.489382266998291 Z M 11.25 3.878570556640625 C 11.25 3.4643568992614746 10.914213180541992 3.128570556640625 10.5 3.128570556640625 C 10.085786819458008 3.128570556640625 9.75 3.4643568992614746 9.75 3.878570556640625 L 9.75 13.378570556640625 C 9.75 13.792783737182617 10.085786819458008 14.128570556640625 10.500000953674316 14.128570556640625 C 10.914214134216309 14.128570556640625 11.25 13.792783737182617 11.25 13.378570556640625 L 11.25 3.878570556640625 Z M 1.2248390913009644 16.420806884765625 C 3.2486952543258667 15.240224838256836 5.751303195953369 15.24022388458252 7.77515983581543 16.420806884765625 L 8.862419128417969 17.055042266845703 C 9.874346733093262 17.64533233642578 11.125653266906738 17.64533233642578 12.137580871582031 17.055042266845703 L 13.22484016418457 16.420806884765625 C 15.248697280883789 15.24022388458252 17.751304626464844 15.240224838256836 19.775161743164062 16.420806884765625 L 19.87790298461914 16.48073959350586 C 20.235692977905273 16.689451217651367 20.356544494628906 17.14868927001953 20.14783477783203 17.50647735595703 C 19.939123153686523 17.864267349243164 19.47988510131836 17.985118865966797 19.12209701538086 17.776409149169922 L 19.01935386657715 17.716476440429688 C 17.462541580200195 16.808334350585938 15.537459373474121 16.808334350585938 13.980647087097168 17.716474533081055 L 12.893387794494629 18.350709915161133 C 11.41441535949707 19.213443756103516 9.58558464050293 19.213443756103516 8.106613159179688 18.350709915161133 L 7.019352912902832 17.716474533081055 C 5.462540626525879 16.808334350585938 3.5374584197998047 16.808334350585938 1.9806456565856934 17.716476440429688 L 1.8779033422470093 17.776409149169922 C 1.5201144218444824 17.985118865966797 1.0608760118484497 17.864267349243164 0.8521658182144165 17.50647735595703 C 0.6434556245803833 17.14868927001953 0.7643077969551086 16.689451217651367 1.1220967769622803 16.48073959350586 L 1.2248390913009644 16.420806884765625 Z")
                    .Add("Icon_Solid_Status_Fire", "F1 M 6.812544345855713 0.05946822836995125 C 6.522911548614502 -0.06751669570803642 6.237647533416748 0.021318286657333374 6.054140567779541 0.2082054316997528 C 5.87588357925415 0.3897457718849182 5.786727428436279 0.6668186187744141 5.849233627319336 0.9461724758148193 C 5.947896480560303 1.3871163129806519 6 1.8458667993545532 6 2.3170852661132812 C 6 3.392928123474121 5.728850841522217 4.146435737609863 5.262299060821533 4.771080493927002 C 4.788025856018066 5.406063079833984 4.1014862060546875 5.923018932342529 3.2346601486206055 6.5063042640686035 C 3.221034049987793 6.515473365783691 3.2083444595336914 6.525962829589844 3.196775436401367 6.537621021270752 L 3.0917890071868896 6.643415451049805 C 1.2319531440734863 7.844968318939209 0 9.937077522277832 0 12.317085266113281 C 0 16.045007705688477 3.022078037261963 19.06708526611328 6.75 19.06708526611328 C 10.477922439575195 19.06708526611328 13.5 16.045007705688477 13.5 12.317085266113281 C 13.5 11.22253131866455 13.239288330078125 10.18814754486084 12.776351928710938 9.273320198059082 C 12.738692283630371 9.198899269104004 12.666397094726562 9.148160934448242 12.583605766296387 9.138045310974121 C 12.500813484191895 9.1279296875 12.418429374694824 9.159770011901855 12.363959312438965 9.222935676574707 C 12.293461799621582 9.3046875 12.224406242370605 9.385371208190918 12.156368255615234 9.464866638183594 C 11.278078079223633 10.49105453491211 10.569293975830078 11.319190979003906 9.116157531738281 11.689109802246094 C 9.054363250732422 11.704840660095215 9.015974998474121 11.693145751953125 8.988734245300293 11.676131248474121 C 8.956673622131348 11.656105041503906 8.921600341796875 11.616119384765625 8.897565841674805 11.552237510681152 C 8.847476959228516 11.419109344482422 8.868971824645996 11.249341011047363 8.971606254577637 11.138066291809082 C 9.748785972595215 10.295466423034668 10.300895690917969 9.151674270629883 10.49818229675293 7.524558067321777 C 10.867738723754883 4.476656913757324 9.482487678527832 1.2300629206001759 6.812544345855713 0.05946822836995125 Z")
                    .Add("Icon_Solid_Status_Heart", "F1 M 5.150000095367432 0 C 2.369142532348633 0 0 2.0793018341064453 0 4.779795169830322 C 0 6.642749786376953 0.8723464012145996 8.211183547973633 2.0284905433654785 9.510425567626953 C 3.180662155151367 10.805203437805176 4.667144775390625 11.892012596130371 6.010973930358887 12.801639556884766 L 8.329587936401367 14.37109088897705 C 8.583511352539062 14.542969703674316 8.916488647460938 14.542969703674316 9.170411109924316 14.37109088897705 L 11.489025115966797 12.801640510559082 C 12.832855224609375 11.892012596130371 14.319337844848633 10.805204391479492 15.471508979797363 9.510425567626953 C 16.627653121948242 8.211183547973633 17.5 6.642749309539795 17.5 4.779795169830322 C 17.5 2.0793018341064453 15.130857467651367 0 12.350000381469727 0 C 10.91652774810791 0 9.655159950256348 0.6721386909484863 8.750000953674316 1.5418329238891602 C 7.844841957092285 0.6721387505531311 6.58347225189209 0 5.150000095367432 0 Z")
            )
            .Content
            (
                GetMainContent(vm)
            ))
            ;
    }

    private UIElement GetMainContent(BindableMainModel vm) =>
        new ScrollViewer()
                    .VerticalAlignment(VerticalAlignment.Stretch)
                    .HorizontalAlignment(HorizontalAlignment.Stretch)
                    .Content
                    (
                        new AutoLayout()
                            .Children
                            (

                               GetTopBar(),

                                new AutoLayout()
                                    .Spacing(16)
                                    .Padding(0, 6, 0, 24)
                                    .Height(666)
                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                    .Children
                                    (
                                       GetSearchBox(vm),

                                       //GetSearchListView(vm)
                                       GetRecomendationChannelBox(),

                                       GetNextShows(vm),

                                       GetPopularChannels(),

                                       GetRecomendations()
                                    ),

                                GetBottomBar()
                                )

            );

    private UIElement GetBottomBar() =>
        new AutoLayout()
            .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
            .Height(85)
            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
            .Children
            (
                new Rectangle()
                    .Width(375)
                    .Height(1)
                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start),
                new AutoLayout()
                    .Justify(AutoLayoutJustify.SpaceBetween)
                    .Orientation(Orientation.Horizontal)
                    .Padding(32, 20, 32, 40)
                    .Width(375)
                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                    .Children
                    (
                        new PathIcon()
                            .Data(StaticResource.Get<Geometry>("Icon_Icon"))
                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start),
                        new PathIcon()
                            .Data(StaticResource.Get<Geometry>("Icon_Icon"))
                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start),
                        new PathIcon()
                            .Data(StaticResource.Get<Geometry>("Icon_Solid_Status_Book_Open"))
                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start),
                        new PathIcon()
                            .Data(StaticResource.Get<Geometry>("Icon_Solid_Status_Heart"))
                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start),
                        new PathIcon()
                            .Data(StaticResource.Get<Geometry>("Icon_Icon"))
                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                    )
            );

    private UIElement GetRecomendations() =>
        new AutoLayout()
                                            .Spacing(16)
                                            .Padding(0, 16, 0, 120)
                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                            .Children
                                            (
                                                new AutoLayout()
                                                    .Spacing(4)
                                                    .Orientation(Orientation.Horizontal)
                                                    .Padding(20, 0)
                                                    .Width(375)
                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                    .Children
                                                    (
                                                        new PathIcon()
                                                            .Data(StaticResource.Get<Geometry>("Icon_Solid_Status_Fire"))
                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center),
                                                        new TextBlock()
                                                            .TextWrapping(TextWrapping.Wrap)
                                                            .Text("Рекомендуем")
                                                            .AutoLayout
                                                            (
                                                                counterAlignment: AutoLayoutAlignment.Center,
                                                                primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                                                            ),
                                                        new AutoLayout()
                                                            .Width(20)
                                                            .Height(20)
                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                            .Children
                                                            (
                                                                new Path()
                                                                    .Data("M 0 0 L 3.75 3.75 L 0 7.5")
                                                                    .Margin(8.333333, 6.25, 7.916667, 6.25)
                                                                    .VerticalAlignment(VerticalAlignment.Stretch)
                                                                    .HorizontalAlignment(HorizontalAlignment.Stretch)
                                                                    .AutoLayout(isIndependentLayout: true)
                                                            )
                                                    ),
                                                new ScrollViewer()
                                                    .HorizontalScrollMode(ScrollMode.Auto)
                                                    .HorizontalScrollBarVisibility(ScrollBarVisibility.Auto)
                                                    .VerticalScrollMode(ScrollMode.Disabled)
                                                    .VerticalScrollBarVisibility(ScrollBarVisibility.Disabled)
                                                    .Height(148)
                                                    .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                                                    .Content
                                                    (
                                                        new AutoLayout()
                                                            .Children
                                                            (
                                                                new AutoLayout()
                                                                    .Spacing(8)
                                                                    .Orientation(Orientation.Horizontal)
                                                                    .Padding(20, 0)
                                                                    .VerticalAlignment(VerticalAlignment.Top)
                                                                    .HorizontalAlignment(HorizontalAlignment.Left)
                                                                    .AutoLayout(isIndependentLayout: true)
                                                                    .Children
                                                                    (
                                                                        new AutoLayout()
                                                                            .CornerRadius(12)
                                                                            .Orientation(Orientation.Horizontal)
                                                                            .Padding(12)
                                                                            .Width(240)
                                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                            .Children
                                                                            (
                                                                                new AutoLayout()
                                                                                    .Spacing(12)
                                                                                    .AutoLayout
                                                                                    (
                                                                                        counterAlignment: AutoLayoutAlignment.Start,
                                                                                        primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                                                                                    )
                                                                                    .Children
                                                                                    (
                                                                                        new AutoLayout()
                                                                                            .Justify(AutoLayoutJustify.SpaceBetween)
                                                                                            .Orientation(Orientation.Horizontal)
                                                                                            .Children
                                                                                            (
                                                                                                new AutoLayout()
                                                                                                    .CornerRadius(6)
                                                                                                    .Orientation(Orientation.Horizontal)
                                                                                                    .Padding(8, 4)
                                                                                                    .Width(136)
                                                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                                                                    .Children
                                                                                                    (
                                                                                                        new TextBlock()
                                                                                                            //.TextAlignment(TextAlignment.Center)
                                                                                                            .Text("Фильм")
                                                                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                                                                    ),
                                                                                                new Border()
                                                                                                    .Width(24)
                                                                                                    .Height(24)
                                                                                                    .CornerRadius(6)
                                                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                                                                    .Child
                                                                                                    (
                                                                                                        new Image()
                                                                                                            .Source(new BitmapImage(new Uri("https://picsum.photos/24/24")))
                                                                                                            .Stretch(Stretch.UniformToFill)
                                                                                                    )
                                                                                            ),
                                                                                        new AutoLayout()
                                                                                            .Children
                                                                                            (
                                                                                                new TextBlock()
                                                                                                    .Text("Механик. Воскрешение")
                                                                                                    .Height(40),
                                                                                                new TextBlock()
                                                                                                    .Text("+16")
                                                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                                            ),
                                                                                        new TextBlock()
                                                                                            .Text("Завтра в 17:00")
                                                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                                    )
                                                                            ),
                                                                        new AutoLayout()
                                                                            .CornerRadius(12)
                                                                            .Orientation(Orientation.Horizontal)
                                                                            .Padding(12)
                                                                            .Width(240)
                                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                            .Children
                                                                            (
                                                                                new AutoLayout()
                                                                                    .Spacing(12)
                                                                                    .AutoLayout
                                                                                    (
                                                                                        counterAlignment: AutoLayoutAlignment.Start,
                                                                                        primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                                                                                    )
                                                                                    .Children
                                                                                    (
                                                                                        new AutoLayout()
                                                                                            .Justify(AutoLayoutJustify.SpaceBetween)
                                                                                            .Orientation(Orientation.Horizontal)
                                                                                            .Children
                                                                                            (
                                                                                                new AutoLayout()
                                                                                                    .CornerRadius(6)
                                                                                                    .Orientation(Orientation.Horizontal)
                                                                                                    .Padding(8, 4)
                                                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                                                    .Children
                                                                                                    (
                                                                                                        new TextBlock()
                                                                                                            //.TextAlignment(TextAlignment.Center)
                                                                                                            .Text("Новости")
                                                                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                                                                    ),
                                                                                                new Border()
                                                                                                    .Width(24)
                                                                                                    .Height(24)
                                                                                                    .CornerRadius(6)
                                                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                                                    .Child
                                                                                                    (
                                                                                                        new Image()
                                                                                                            .Source(new BitmapImage(new Uri("https://picsum.photos/24/24")))
                                                                                                            .Stretch(Stretch.UniformToFill)
                                                                                                    )
                                                                                            ),
                                                                                        new AutoLayout()
                                                                                            .Children
                                                                                            (
                                                                                                new TextBlock()
                                                                                                    .Text("Вечерние новости с субтитрами")
                                                                                                    .Height(40),
                                                                                                new TextBlock()
                                                                                                    .Text("+0")
                                                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                                            ),
                                                                                        new TextBlock()
                                                                                            .Text("Завтра в 14:00")
                                                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                                    )
                                                                            )
                                                                    )
                                                            )
                                                    )
                                            );

    private UIElement GetPopularChannels() =>
        new AutoLayout()
                .Spacing(16)
                .Padding(0, 16, 0, 0)
                .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                .Children
                (
                    new AutoLayout()
                        .Spacing(8)
                        .Orientation(Orientation.Horizontal)
                        .Padding(20, 0)
                        .Width(375)
                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                        .Children
                        (
                            new TextBlock()
                                .TextWrapping(TextWrapping.Wrap)
                                .Text("Популярные телеканалы")
                                .AutoLayout
                                (
                                    counterAlignment: AutoLayoutAlignment.Center,
                                    primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                                ),
                            new AutoLayout()
                                .Width(20)
                                .Height(20)
                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                .Children
                                (
                                    new Path()
                                        .Data("M 0 0 L 3.75 3.75 L 0 7.5")
                                        .Margin(8.333333, 6.25, 7.916667, 6.25)
                                        .VerticalAlignment(VerticalAlignment.Stretch)
                                        .HorizontalAlignment(HorizontalAlignment.Stretch)
                                        .AutoLayout(isIndependentLayout: true)
                                )
                        ),
                    new ScrollViewer()
                        .HorizontalScrollMode(ScrollMode.Auto)
                        .HorizontalScrollBarVisibility(ScrollBarVisibility.Auto)
                        .VerticalScrollMode(ScrollMode.Disabled)
                        .VerticalScrollBarVisibility(ScrollBarVisibility.Disabled)
                        .Height(80)
                        .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                        .Content
                        (
                            new AutoLayout()
                                .Children
                                (
                                    new AutoLayout()
                                        .Orientation(Orientation.Horizontal)
                                        .Padding(20, 0)
                                        .VerticalAlignment(VerticalAlignment.Top)
                                        .HorizontalAlignment(HorizontalAlignment.Left)
                                        .AutoLayout(isIndependentLayout: true)
                                        .Children
                                        (
                                            new AutoLayout()
                                                .Spacing(8)
                                                .Padding(0, 8, 0, 0)
                                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                .Children
                                                (
                                                    new Border()
                                                        .Width(48)
                                                        .Height(48)
                                                        .CornerRadius(12)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                        .Child
                                                        (
                                                            new Image()
                                                                .Source(new BitmapImage(new Uri("https://picsum.photos/48/48")))
                                                                .Stretch(Stretch.UniformToFill)
                                                        ),
                                                    new TextBlock()
                                                        //.TextAlignment(TextAlignment.Center)
                                                        .Text("Рен ТВ")
                                                        .Width(80)
                                                        .Height(16)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                ),
                                            new AutoLayout()
                                                .Spacing(8)
                                                .Padding(0, 8, 0, 0)
                                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                .Children
                                                (
                                                    new Border()
                                                        .Width(48)
                                                        .Height(48)
                                                        .CornerRadius(12)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                        .Child
                                                        (
                                                            new Image()
                                                                .Source(new BitmapImage(new Uri("https://picsum.photos/48/48")))
                                                                .Stretch(Stretch.UniformToFill)
                                                        ),
                                                    new TextBlock()
                                                        //.TextAlignment(TextAlignment.Center)
                                                        .Text("Телекомпания НТВ")
                                                        .Width(80)
                                                        .Height(16)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                ),
                                            new AutoLayout()
                                                .Spacing(8)
                                                .Padding(0, 8, 0, 0)
                                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                .Children
                                                (
                                                    new Border()
                                                        .Width(48)
                                                        .Height(48)
                                                        .CornerRadius(12)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                        .Child
                                                        (
                                                            new Image()
                                                                .Source(new BitmapImage(new Uri("https://picsum.photos/48/48")))
                                                                .Stretch(Stretch.UniformToFill)
                                                        ),
                                                    new TextBlock()
                                                        //.TextAlignment(TextAlignment.Center)
                                                        .Text("СПАС")
                                                        .Width(80)
                                                        .Height(16)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                ),
                                            new AutoLayout()
                                                .Spacing(8)
                                                .Padding(0, 8, 0, 0)
                                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                .Children
                                                (
                                                    new Border()
                                                        .Width(48)
                                                        .Height(48)
                                                        .CornerRadius(12)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                        .Child
                                                        (
                                                            new Image()
                                                                .Source(new BitmapImage(new Uri("https://picsum.photos/48/48")))
                                                                .Stretch(Stretch.UniformToFill)
                                                        ),
                                                    new TextBlock()
                                                        //.TextAlignment(TextAlignment.Center)
                                                        .Text("Пятница")
                                                        .Width(80)
                                                        .Height(16)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                ),
                                            new AutoLayout()
                                                .Spacing(8)
                                                .Padding(0, 8, 0, 0)
                                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                .Children
                                                (
                                                    new Border()
                                                        .Width(48)
                                                        .Height(48)
                                                        .CornerRadius(12)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                        .Child
                                                        (
                                                            new Image()
                                                                .Source(new BitmapImage(new Uri("https://picsum.photos/48/48")))
                                                                .Stretch(Stretch.UniformToFill)
                                                        ),
                                                    new TextBlock()
                                                        //.TextAlignment(TextAlignment.Center)
                                                        .Text("Звезда")
                                                        .Width(80)
                                                        .Height(16)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                )
                                        )
                                )
                        )
                );

    private UIElement GetNextShows(BindableMainModel vm) =>
        new AutoLayout()
            .Spacing(16)
            .Padding(0, 16, 0, 0)
            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
            .Children
            (
                new AutoLayout()
                    .Spacing(8)
                    .Orientation(Orientation.Horizontal)
                    .Padding(20, 0)
                    .Width(375)
                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                    .Children
                    (
                        new TextBlock()
                            .TextWrapping(TextWrapping.Wrap)
                            .Text("Скоро начало")
                            .AutoLayout
                            (
                                counterAlignment: AutoLayoutAlignment.Center,
                                primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                            ),
                        new AutoLayout()
                            .Width(20)
                            .Height(20)
                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                            .Children
                            (
                                new Path()
                                    .Data("M 0 0 L 3.75 3.75 L 0 7.5")
                                    .Margin(8.333333, 6.25, 7.916667, 6.25)
                                    .VerticalAlignment(VerticalAlignment.Stretch)
                                    .HorizontalAlignment(HorizontalAlignment.Stretch)
                                    .AutoLayout(isIndependentLayout: true)
                            )
                    ),
                new ScrollViewer()
                    .HorizontalScrollMode(ScrollMode.Auto)
                    .HorizontalScrollBarVisibility(ScrollBarVisibility.Auto)
                    .VerticalScrollMode(ScrollMode.Disabled)
                    .VerticalScrollBarVisibility(ScrollBarVisibility.Disabled)
                    .Height(148)
                    .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                    .Content
                    (
                        new AutoLayout()
                            .Children
                            (
                                new AutoLayout()
                                    .Spacing(8)
                                    .Orientation(Orientation.Horizontal)
                                    .Padding(20, 0)
                                    .VerticalAlignment(VerticalAlignment.Top)
                                    .HorizontalAlignment(HorizontalAlignment.Left)
                                    .AutoLayout(isIndependentLayout: true)
                                    .Children
                                    (
                                        new AutoLayout()
                                            .CornerRadius(12)
                                            .Orientation(Orientation.Horizontal)
                                            .Padding(12)
                                            .Width(180)
                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                            .Children
                                            (
                                                new AutoLayout()
                                                    .Spacing(12)
                                                    .AutoLayout
                                                    (
                                                        counterAlignment: AutoLayoutAlignment.Start,
                                                        primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                                                    )
                                                    .Children
                                                    (
                                                        new AutoLayout()
                                                            .Justify(AutoLayoutJustify.SpaceBetween)
                                                            .Orientation(Orientation.Horizontal)
                                                            .Children
                                                            (
                                                                new AutoLayout()
                                                                    .CornerRadius(6)
                                                                    .Orientation(Orientation.Horizontal)
                                                                    .Padding(8, 4)
                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                    .Children
                                                                    (
                                                                        new TextBlock()
                                                                            //.TextAlignment(TextAlignment.Center)
                                                                            .Text("Познавательное")
                                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                                    ),
                                                                new Border()
                                                                    .Width(24)
                                                                    .Height(24)
                                                                    .CornerRadius(6)
                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                    .Child
                                                                    (
                                                                        new Image()
                                                                            .Source(new BitmapImage(new Uri("https://snipboard.io/Uj7rFx.jpg")))
                                                                            .Stretch(Stretch.UniformToFill)
                                                                    )
                                                            ),
                                                        new AutoLayout()
                                                            .Children
                                                            (
                                                                new TextBlock()
                                                                    .Text("«Человек и Закон» с Алексеем Пимановым")
                                                                    .Height(40),
                                                                new TextBlock()
                                                                    .Text("+0")
                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                            ),
                                                        new TextBlock()
                                                            .Text("Через 21 мин")
                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                    )
                                            ),
                                        new AutoLayout()
                                            .CornerRadius(12)
                                            .Orientation(Orientation.Horizontal)
                                            .Padding(12)
                                            .Width(180)
                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                            .Children
                                            (
                                                new AutoLayout()
                                                    .Spacing(12)
                                                    .AutoLayout
                                                    (
                                                        counterAlignment: AutoLayoutAlignment.Start,
                                                        primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                                                    )
                                                    .Children
                                                    (
                                                        new AutoLayout()
                                                            .Justify(AutoLayoutJustify.SpaceBetween)
                                                            .Orientation(Orientation.Horizontal)
                                                            .Children
                                                            (
                                                                new AutoLayout()
                                                                    .CornerRadius(6)
                                                                    .Orientation(Orientation.Horizontal)
                                                                    .Padding(8, 4)
                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                    .Children
                                                                    (
                                                                        new TextBlock()
                                                                            //.TextAlignment(TextAlignment.Center)
                                                                            .Text("Фильм")
                                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                                    ),
                                                                new Border()
                                                                    .Width(24)
                                                                    .Height(24)
                                                                    .CornerRadius(6)
                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                                    .Child
                                                                    (
                                                                        new Image()
                                                                            .Source(new BitmapImage(new Uri("https://snipboard.io/q4StHo.jpg")))
                                                                            .Stretch(Stretch.UniformToFill)
                                                                    )
                                                            ),
                                                        new AutoLayout()
                                                            .Children
                                                            (
                                                                new TextBlock()
                                                                    .Text("Механик. Воскрешение")
                                                                    .Height(40),
                                                                new TextBlock()
                                                                    .Text("+16")
                                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                            ),
                                                        new TextBlock()
                                                            .Text("Через 21 мин")
                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                    )
                                            )
                                    )
                            )
                    )
            );

    private UIElement GetTopBar() =>
         new AutoLayout()
                                    .Spacing(8)
                                    .Orientation(Orientation.Horizontal)
                                    .Padding(20, 16)
                                    .Width(375)
                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                    .Children
                                    (
                                        new PathIcon()
                                            .Data(StaticResource.Get<Geometry>("Icon_Solid_Status_Book_Open"))
                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center),
                                        new TextBlock()
                                            .TextWrapping(TextWrapping.Wrap)
                                            .Text("Телепрограмма")
                                            .AutoLayout
                                            (
                                                counterAlignment: AutoLayoutAlignment.Center,
                                                primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                                            ),
                                        new AutoLayout()
                                            .Width(32)
                                            .Height(32)
                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                    );

    private UIElement GetSearchBox(BindableMainModel vm) =>
         new AutoLayout()
                                            .Background(Theme.Brushes.Surface.Default)
                                            .Padding(12, 11, 12, 12)
                                            .Height(63)
                                            .Children
                                            (
                                                new TextBox()
                                                    .Background(Theme.Brushes.Surface.Variant.Default)
                                                    .Text(b => b.Bind(() => vm.SearchTerm).TwoWay().UpdateSourceTrigger(UpdateSourceTrigger.PropertyChanged))
                                                    .Height(40)
                                                    .PlaceholderText("Поиск")
                                                    .CornerRadius(20)
                                                    .BorderThickness(0)
                                                    .Style(Theme.TextBox.Styles.Outlined)
                                                    .ControlExtensions
                                                    (
                                                        icon:
                                                            new PathIcon()
                                                                .Data(StaticResource.Get<Geometry>("Icon_Search"))
                                                                .Foreground(Theme.Brushes.OnSurface.Variant.Default)
                                                    )
                                            );

    private UIElement GetSearchListView(BindableMainModel vm) =>
        new ListView()
            .Background(Theme.Brushes.Background.Default)
            .ItemsSource(() => vm.SearchShowsResults)
            .Padding(12, 8)
            //.Navigation(request: "VideoDetails")
            .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
            .IsItemClickEnabled(true)
            .ItemTemplate<SearchResultItem>
            (
                resultItem =>
                    new CardContentControl()
                        .Margin(0, 0, 0, 8)
                        .Style(StaticResource.Get<Style>("ElevatedCardContentControlStyle"))
                        .Content
                        (
                            new AutoLayout()
                                .Background(Theme.Brushes.Surface.Default)
                                .CornerRadius(12)
                                .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                                .Children
                                (
                                    new AutoLayout()
                                        .Background(Theme.Brushes.Surface.Default)
                                        .CornerRadius(12)
                                        .Padding(8, 8, 8, 0)
                                        .MaxHeight(288)
                                        .MaxWidth(456)
                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                        .Children
                                        (
                                            new Border()
                                                .Height(204.75)
                                                .CornerRadius(6)
                                                .Child
                                                (
                                                    new Image()
                                                        .Source(() => resultItem.Details?.ImgUrl!)
                                                        .Stretch(Stretch.UniformToFill)
                                                ),
                                            new AutoLayout()
                                                .Spacing(8)
                                                .Orientation(Orientation.Horizontal)
                                                .Padding(0, 8)
                                                .Children
                                                (
                                                    new Border()
                                                        .Width(60)
                                                        .Height(60)
                                                        .CornerRadius(6)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                        .Child
                                                        (
                                                            new Image()
                                                                .Source(() => resultItem.Details?.ImgUrl!)
                                                                .Stretch(Stretch.UniformToFill)
                                                        ),
                                                    new AutoLayout()
                                                        .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                                                        .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                                                        .Children
                                                        (
                                                            new TextBlock()
                                                                .Text(() => resultItem.Details?.Snippet.Title)
                                                                .Height(22)
                                                                .Foreground(Theme.Brushes.OnSurface.Default)
                                                                .Style(Theme.TextBlock.Styles.TitleMedium)
                                                        ),
                                                    new Button()
                                                        .Foreground(Theme.Brushes.OnSurface.Variant.Default)
                                                        .Style(Theme.Button.Styles.Icon)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                        .Content
                                                        (
                                                            new PathIcon()
                                                                .Data(StaticResource.Get<Geometry>("Icon_Chevron_Right"))
                                                                .Foreground(Theme.Brushes.OnSurface.Variant.Default)
                                                        )
                                                )
                                        )
                                )
                        )
            );

    private UIElement GetRecomendationChannelBox() =>
         new AutoLayout()
                                            .CornerRadius(10)
                                            .Justify(AutoLayoutJustify.SpaceBetween)
                                            .Orientation(Orientation.Horizontal)
                                            .Padding(36, 16)
                                            .Width(335)
                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                            .Children
                                            (
                                                new AutoLayout()
                                                    .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                    .Children
                                                    (
                                                        new TextBlock()
                                                            .Text("Ваш канал")
                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start),
                                                        new TextBlock()
                                                            .Text("Основано на ваших предпочтениях")
                                                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
                                                    ),
                                                new AutoLayout()
                                                    .Width(36)
                                                    .Height(36)
                                                    .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                            );
}
