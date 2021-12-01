import 'package:boilerplate_flutter/models/room.dart';
import 'package:boilerplate_flutter/modules/datails_room/details_room_page.dart';
import 'package:boilerplate_flutter/modules/list_rooms/list_rooms_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:page_transition/page_transition.dart';

import 'configure.dart';
import 'modules/home/home_page.dart';
import 'modules/login/login_page.dart';
import 'modules/wrapper/wrapper_page.dart';
import 'theme.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await dotenv.load();
  await configure();
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) => MaterialApp(
        title: 'Flutter Demo',
        theme: theme,
        debugShowCheckedModeBanner: false,
        home: WrapperPage(),
        onGenerateRoute: (settings) {
          switch (settings.name) {
            case '/login':
              return PageTransition(
                  child: LoginPage(), type: PageTransitionType.fade);
            case '/home':
              return PageTransition(
                  child: HomePage(), type: PageTransitionType.fade);
            case '/listRooms':
              return PageTransition(
                  child: ListRoomsPage(), type: PageTransitionType.fade);

            case '/detailsRoom':
              return PageTransition(
                  child: DetailsRoomPage(
                    roomModel: settings.arguments as RoomModel,
                  ),
                  type: PageTransitionType.fade);
            default:
              return null;
          }
        },
      );
}
