

import 'package:card_swiper/card_swiper.dart';
import 'package:drawerbehavior/drawerbehavior.dart';
import 'package:flutter/material.dart';
import 'package:flutter_animate/flutter_animate.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:overlapped_carousel/overlapped_carousel.dart';
import 'package:untitled/Views/DetailRandonn%C3%A9.dart';

import '../../Http/HttpService.dart';
import '../../Http/Models.dart';

class EventPage extends StatefulWidget {
  const EventPage({super.key});

  @override
  State<EventPage> createState() => _EventPageState();
}

class _EventPageState extends State<EventPage> {


  double containerWidth = 100.0;
  String selectedMenuItemId = ""; // Change the type to String
  List<Event> trails = [];
  List<Event> completedTrails = [];
  List<Event> newTrails = [];
  int nbEvents = 0;
  int nbNewTrails = 0;
  int nbCompletedTrails = 0;
  int nbCarouselItems = 6;
  Event event = new Event();


  Future<Event?> getListEvents() async {
    List<Event> response = await getEvents();
    print(trails);
    setState(() {
      trails = response;
      nbEvents = trails.length;
      event = trails[0];

      for(int i = 0; i < nbEvents; i++){
        if(trails[i].isNew){
          nbNewTrails++;
        }
        if(trails[i].isCompleted){
          nbCompletedTrails++;
        }
      }
    });

  }

  void getEvent(int index) {
    setState(() {
      event = trails[index];
    });
  }

   getNewTrails() async{
    newTrails = [];
    List<Event> response = await getEvents();
    for (int i = 0; i < response.length; i++) {
      if (response[i].isNew) {
        newTrails.add(response[i]);
      }
    }
    setState(() {
      trails = newTrails;
      if(trails.length >= 6){
        nbCarouselItems = 6;
      }
      else{
        nbCarouselItems = trails.length;
      }
    });
  }

  getCompletedTrails() async{
    completedTrails = [];
    List<Event> response = await getEvents();
    for (int i = 0; i < response.length; i++) {
      if (response[i].isCompleted) {
        completedTrails.add(response[i]);
      }
    }
    setState(() {
      trails = completedTrails;
      if(trails.length >= 6){
        nbCarouselItems = 6;
      }
      else{
        nbCarouselItems = trails.length;
      }
    });
  }

  @override
  void initState() {
    super.initState();
    getListEvents();
  }

  @override
  Widget build(BuildContext context) {

    Size size = MediaQuery
        .of(context)
        .size;
    double width = size.width;
    double height = size.height;
    double paddingUserInfo = height * 0.1;


    return Scaffold(
        body:  ListView(
          children: [
            Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                //this is the header of the page
                Padding(
                  padding: EdgeInsets.only(left: width * 0.04, right: 10),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text("Explore", style: GoogleFonts.plusJakartaSans(
                          textStyle: const TextStyle(
                            fontSize: 26,
                            fontWeight: FontWeight.w800,
                            color: Colors.black,
                          )
                      ), textAlign: TextAlign.left,),
                      Padding(
                        padding: const EdgeInsets.only(left: 10),
                        child: SingleChildScrollView(
                          scrollDirection: Axis.horizontal,
                          child:  Row(
                            children: [
                              eventSelector("assets/Images/alli.png", "All events", nbEvents.toString() + " events"),
                              SizedBox(width: 20),
                              GestureDetector(
                                onTap: () async{
                                  await getNewTrails();
                                },
                                child:eventSelector("assets/Images/newTrail.png", "New trails", nbNewTrails.toString() + " new trails"),
                              ),
                              SizedBox(width: 20),
                              GestureDetector(
                                onTap: () async{
                                  await getCompletedTrails();
                                },
                                child:eventSelector("assets/Images/userActivity.png", "User activity", nbCompletedTrails.toString() + " completed trails"),
                              ),
                              SizedBox(width: 20),
                            ],
                          ),
                        ),
                      ),
                      SizedBox(height: 20),
                      Text("Most recent events", style: GoogleFonts.plusJakartaSans(
                          textStyle: const TextStyle(
                            fontSize: 22,
                            fontWeight: FontWeight.w700,
                            color: Color(0xFF575656),
                          )
                      ), textAlign: TextAlign.left,),
                      SizedBox(height: 20),
                    ],
                  ),
                ),
                //this is the carousel
                Container(
                  child: SizedBox(
                    height : height *0.3,
                    width: width,
                    child: trails.isNotEmpty?Swiper(
                      itemBuilder: (BuildContext context,int index){
                        if(trails[index].isNew)
                          return EventImage(width: width, height: height, isNew: true, event: trails[index]);
                        else
                          return EventImage(width: width, height: height, isNew: false, event: trails[index]);
                      },
                      itemCount: nbCarouselItems,
                      pagination: SwiperPagination(),
                        itemWidth: width *0.85,
                        loop:true,
                        autoplay: true,
                        layout: SwiperLayout.STACK,
                        onIndexChanged: (int index) => getEvent(index),
                    ):Container( ),
                  ),
                ),
                Container(
                    height: height * 0.17,
                    child: TrailCarouselinformation(width: width, event: event,)
                ),
                Padding(
                  padding: EdgeInsets.only(left: width * 0.04, right: 10),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text("Most recent events", style: GoogleFonts.plusJakartaSans(
                          textStyle: const TextStyle(
                            fontSize: 22,
                            fontWeight: FontWeight.w700,
                            color: Color(0xFF575656),
                          )
                      ), textAlign: TextAlign.left,),
                      if (trails != null)
                        ListView.builder(
                          shrinkWrap: true,
                          physics: NeverScrollableScrollPhysics(),
                          itemCount: trails.length,
                          itemBuilder: (context, index) {
                            if (trails[index].isNew) {
                              return TrailEventCard(width: width, isNew: true, event: trails[index]);
                            } else {
                              return TrailEventCard(width: width, isNew: false, event: trails[index]);
                            }
                          },
                        ),
                    ],
                  ),
                )
              ],
            ),
          ],
        ),
    );
  }

  Row eventSelector(String image, String title, String number) {
    return Row(
      children: [
        Container(
          height: 60,
          width: 60,
          margin: EdgeInsets.only(top: 20),
          decoration: BoxDecoration(
            color: Color(0x62000000),
            borderRadius: BorderRadius.circular(10),
          ),
          child: new Image.asset(
            image,
            fit: BoxFit.cover,
          ),
        ),
        Container(
          margin: EdgeInsets.only(left: 10),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text(title, style: GoogleFonts.plusJakartaSans(
                  textStyle: const TextStyle(
                    fontSize: 20,
                    fontWeight: FontWeight.w600,
                    color: Colors.black,
                  )
              ), textAlign: TextAlign.left,),
              Text(number, style: GoogleFonts.plusJakartaSans(
                  textStyle: const TextStyle(
                    fontSize: 16,
                    fontWeight: FontWeight.w500,
                    color: Colors.black,
                  )
              ), textAlign: TextAlign.left,),
            ],
          ),
        ),
      ],
    );
  }
}

class TrailEventCard extends StatelessWidget {
  const TrailEventCard({
    super.key,
    required this.width,
    required this.isNew,
    required this.event,
  });

  final double width;
  final bool isNew;
  final Event event;


  @override
  Widget build(BuildContext context) {

    return GestureDetector(
      onTap: () {
        Navigator.push(
            context, MaterialPageRoute(builder: (context) => DetailRandonne(randonne: event.trail))
        );
      },
      child: Container(
        margin: EdgeInsets.only(top: 20, left: 10),
        padding: EdgeInsets.all(10),
        decoration: BoxDecoration(
          color: Color(0xdb000000),
          borderRadius: BorderRadius.circular(10),
        ),
        child: Padding(
          padding: const EdgeInsets.all(10),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Padding(
                padding: const EdgeInsets.only(bottom: 5),
                child: Row(
                  children: [
                    ClipRRect(
                      borderRadius: BorderRadius.circular(40),
                      child: Image.asset(
                        "assets/Images/avatarPlaceHolder.png",
                        width: 40,
                        height: 40,
                      ),
                    ),
                    SizedBox(width: 10),
                    Text(event.userName, style: GoogleFonts.plusJakartaSans(
                        textStyle: const TextStyle(
                          fontSize: 16,
                          fontWeight: FontWeight.w700,
                          color: Colors.white,
                        )
                    ), textAlign: TextAlign.left,),
                    //show the rating of the trail
                    Spacer(),
                    //only show the icon and text if isNew IS FALSE
                    (!isNew) ? Row(
                      children: [
                        Icon(Icons.star, color: Color(0xFFFCBF31), size: 20,),
                        Text(event.trail.rating.toString(), style: GoogleFonts.plusJakartaSans(
                            textStyle: const TextStyle(
                              fontSize: 16,
                              fontWeight: FontWeight.w700,
                              color: Colors.white,
                            )
                        ), textAlign: TextAlign.left,),
                      ],
                    ) : Container(
                      margin: EdgeInsets.only(left: 10),
                      padding: EdgeInsets.all(5),
                      decoration: BoxDecoration(
                        color: Color(0xFFFCBF31),
                        borderRadius: BorderRadius.circular(10),
                        border: Border.all(
                          color: Color(0xFF000000),
                          width: 1.5,
                        ),
                      ),
                      child: Text("New!", style: GoogleFonts.plusJakartaSans(
                          textStyle: const TextStyle(
                            fontSize: 18,
                            fontWeight: FontWeight.w800,
                            color: Color(0xFF000000),
                          )
                      ), textAlign: TextAlign.left,),
                    ),
                    //if is isNew is try show that this trai il new


                  ],
                ),
              ),
              Stack(
                children: [
                  ClipRRect(
                    borderRadius: BorderRadius.circular(10),
                    child: Image.asset(
                      "assets/Images/test2.jpg",
                      width: width * 0.80,
                    ),
                  ),
                  Align(
                    alignment: Alignment.center,
                      child: Container(
                        width: width * 0.65,
                        margin: EdgeInsets.only(top: 10),
                        decoration: BoxDecoration(
                          color: Color(0xC2FFFFFF),
                          borderRadius: BorderRadius.circular(10),
                          border: Border.all(
                            color: Color(0xFF000000),
                            width: 1.5,
                          ),
                        ),
                        child: Padding(
                          padding: const EdgeInsets.all(4.0),
                          child: Text(event.trail.name, style: GoogleFonts.plusJakartaSans(
                              textStyle: const TextStyle(
                                fontSize: 18,
                                fontWeight: FontWeight.w700,
                                color: Color(0xFF000000),
                              )
                          ), textAlign: TextAlign.left,),
                        ),
                      )
                  )
                ],
              ),
              SizedBox(height: 10),
              //add a description test
              Text(event.trail.description, style: GoogleFonts.plusJakartaSans(
                  textStyle: const TextStyle(
                    fontSize: 16,
                    fontWeight: FontWeight.w500,
                    color: Colors.white,
                  )
              ), textAlign: TextAlign.left,),
              Align(
                alignment: Alignment.centerRight,
                child: Text("2 days ago", style: GoogleFonts.plusJakartaSans(
                    textStyle: const TextStyle(
                      fontSize: 16,
                      fontWeight: FontWeight.w500,
                      color: Colors.white,
                    )
                ), textAlign: TextAlign.right,),
              ),
            ],
          ),
        ),
      ),
    );
  }
}

class TrailCarouselinformation extends StatelessWidget {
  const TrailCarouselinformation({
    super.key,
    required this.width,
    required this.event
  });

  final double width;
  final Event event;

  @override
  Widget build(BuildContext context) {

    //format la date de l event afin d avoir juste la date sans l heure et les minutes
    String date = event.date.toString().substring(0, 10);

    return Padding(
      padding: const EdgeInsets.only(left: 30, right: 30),
      child: Row(
        //align the items at the top
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Padding(
            padding: const EdgeInsets.only(top: 10),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(date, style: GoogleFonts.plusJakartaSans(
                    textStyle: const TextStyle(
                      fontSize: 16,
                      fontWeight: FontWeight.w700,
                      color: Color(0xFF575656),
                    )
                ), textAlign: TextAlign.left,),
                SizedBox(width: width * 0.5, child: Text(event.trail.name, style: GoogleFonts.plusJakartaSans(
                    textStyle: const TextStyle(
                      fontSize: 18,
                      fontWeight: FontWeight.w700,
                      color: Color(0xFF000000),
                    )
                ), textAlign: TextAlign.left,),),
                SizedBox(
                  width: width * 0.5,
                  child: Text(event.trail.location, style: GoogleFonts.plusJakartaSans(
                      textStyle: const TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.w500,
                        color: Color(0xFF575656),
                      )
                  ), textAlign: TextAlign.left,),
                ),


              ],
            ),
          ),
          Spacer(),
          GestureDetector(
            onTap: () {
              //navigate to the detail page
              Navigator.push(
                  context, MaterialPageRoute(builder: (context) => DetailRandonne(randonne: event.trail))
              );
            },
            child: Container(
                margin: EdgeInsets.only(top: 10),
                decoration: BoxDecoration(
                  color: Color(0xFFFCBF31),
                  borderRadius: BorderRadius.circular(25),
                  border: Border.all(
                    color: Color(0xFF000000),
                    width: 1.5,
                  ),
                  boxShadow: [
                    BoxShadow(
                      color: Color(0x66000000),
                      offset: Offset(2, 6),
                      blurRadius: 6,
                      spreadRadius:1,
                    )
                  ],
                ),
                child: Padding(
                  padding: const EdgeInsets.all(8),
                  child : Text("Interested", style: GoogleFonts.plusJakartaSans(
                      textStyle: const TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.w700,
                        color: Color(0xFFFFFFFF),
                      )
                  ), textAlign: TextAlign.left,),
                )
            ),
          )
        ],
      ),
    );
  }
}

class EventImage extends StatelessWidget {
  const EventImage({
    super.key,
    required this.width,
    required this.height,
    required this.isNew,
    required this.event
  });

  final double width;
  final double height;
  final bool isNew;
  final Event event;

  @override
  Widget build(BuildContext context) {
    var icon;
    if(event.trail.type == 1){
      icon = IconData(0xe1d2, fontFamily: 'MaterialIcons');
    }
    else{
      icon = IconData(0xe1e1, fontFamily: 'MaterialIcons');
    }


    return Stack(
      clipBehavior: Clip.none,
      children: [
        Container(
          width: width * 0.95,
          height: height * 0.3,
          decoration: BoxDecoration(
            color: Color(0x62000000),
            borderRadius: BorderRadius.circular(10),
          ),
          child: ClipRRect(
            borderRadius: BorderRadius.circular(10),
            child: (event.trail.imageUrl != null && event.trail.imageUrl != "") ? Image.network(
              event.trail.imageUrl!,
              fit: BoxFit.cover,
            ) :
            Image.asset(
              "assets/Images/test2.jpg",
              fit: BoxFit.cover,
            ),
          ),
        ),
        Positioned(
          top: 10,
          left: 10,
          child: Container(
            width: width * 0.2,
            height: height * 0.05,
            decoration: BoxDecoration(
              color: Color(0xDB000000),
              borderRadius: BorderRadius.circular(5),
              border: Border.all(
                color: Colors.white,
                width: 2,
              ),
            ),
            child: Center(
              child: Icon(icon, color: Colors.white, size: 32,),
            ),
          ),
        ),
        Positioned(
          top: 10,
          right: 10,
          child: (!isNew) ? Container(
            width: width * 0.2,
            height: height * 0.05,
            decoration: BoxDecoration(
              color: Color(0xDB000000),
              borderRadius: BorderRadius.circular(5),
              border: Border.all(
                color: Colors.white,
                width: 2,
              ),
            ),
            child: Center(
              child: Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Icon(Icons.star, color: Color(0xFFFCBF31), size: 20,),
                  Text(event.trail.rating.toString(), style: GoogleFonts.plusJakartaSans(
                      textStyle: const TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.w700,
                        color: Colors.white,
                      )
                  ), textAlign: TextAlign.center,),
                ],
              ),
            ),
          ) : Container(
            width: width * 0.2,
            height: height * 0.05,
            decoration: BoxDecoration(
              color: Color(0xFFFCBF31),
              borderRadius: BorderRadius.circular(5),
              border: Border.all(
                color: Colors.white,
                width: 2,
              ),
            ),
            child: Center(
              child: Text("New!", style: GoogleFonts.plusJakartaSans(
                  textStyle: const TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.w800,
                    color: Colors.white,
                  )
              ), textAlign: TextAlign.center,),
            ),
          ),
        ),
      ],
    );

  }
}