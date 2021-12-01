import 'package:boilerplate_flutter/modules/home/home_page.dart';
import 'package:boilerplate_flutter/modules/list_rooms/list_rooms_page.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';

import '../login/login_page.dart';
import 'home_cubit.dart';
import 'home_state.dart';

class HomeContent extends StatelessWidget {
  static String route = '/home';

  const HomeContent({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return BlocConsumer<HomeCubit, HomeState>(
      listener: (context, state) {
        if (state.exited) {
          Navigator.pushNamedAndRemoveUntil(
              context, LoginPage.route, (route) => false);
        }
      },
      builder: (context, state) {
        return LayoutBuilder(
            builder: (_, constraints) => SafeArea(
                    child: Stack(
                  children: [
                    Center(
                      child: SingleChildScrollView(
                        scrollDirection: Axis.horizontal,
                        child: Column(
                          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                          children: [
                            SizedBox(
                              height: 16,
                            ),
                            Row(
                              children: [
                                Container(
                                  width: constraints.maxWidth * .7,
                                  height: constraints.maxHeight * .5,
                                  child: Card(
                                    shape: RoundedRectangleBorder(
                                        borderRadius:
                                            BorderRadius.circular(10)),
                                    child: Column(
                                      children: [
                                        SizedBox(
                                          height: 16,
                                        ),
                                        Icon(
                                          Icons.map_outlined,
                                          size: constraints.maxHeight * .1,
                                        ),
                                        Row(
                                          mainAxisAlignment:
                                              MainAxisAlignment.center,
                                          children: const [
                                            Text('Atrações e Tours',
                                                style: TextStyle(
                                                  fontSize: 20,
                                                  color: Colors.black,
                                                ))
                                          ],
                                        ),
                                        Wrap(
                                          children: const [
                                            Padding(
                                              padding:
                                                  const EdgeInsets.all(25.0),
                                              child: Text(
                                                'Com os nossos tours, você consegue aproveitar ao máximo todas atrações a que tem direito, tornando ainda mais inesquecível a sua experiência conosco!',
                                                textAlign: TextAlign.justify,
                                                style: TextStyle(
                                                  color: Colors.black,
                                                ),
                                              ),
                                            ),
                                          ],
                                        )
                                      ],
                                    ),
                                  ),
                                ),
                                Container(
                                  width: constraints.maxWidth * .7,
                                  height: constraints.maxHeight * .5,
                                  child: Card(
                                    shape: RoundedRectangleBorder(
                                        borderRadius:
                                            BorderRadius.circular(10)),
                                    child: Column(
                                      children: [
                                        SizedBox(
                                          height: 16,
                                        ),
                                        Icon(
                                          Icons.pets,
                                          size: constraints.maxHeight * .1,
                                        ),
                                        Row(
                                          mainAxisAlignment:
                                              MainAxisAlignment.center,
                                          children: const [
                                            Text('Pet Friendly',
                                                style: TextStyle(
                                                  fontSize: 20,
                                                  color: Colors.black,
                                                ))
                                          ],
                                        ),
                                        Wrap(
                                          children: const [
                                            Padding(
                                              padding:
                                                  const EdgeInsets.all(25.0),
                                              child: Text(
                                                'Porque não trazer seu pet para tirar um descanso também? Aqui, além dele ser bem-vindo, recebe tratamento de primeira com nossa equipe especializada.',
                                                textAlign: TextAlign.justify,
                                                style: TextStyle(
                                                  color: Colors.black,
                                                ),
                                              ),
                                            ),
                                          ],
                                        )
                                      ],
                                    ),
                                  ),
                                ),
                                Container(
                                  width: constraints.maxWidth * .7,
                                  height: constraints.maxHeight * .5,
                                  child: Card(
                                    shape: RoundedRectangleBorder(
                                        borderRadius:
                                            BorderRadius.circular(10)),
                                    child: Column(
                                      children: [
                                        SizedBox(
                                          height: 16,
                                        ),
                                        Icon(
                                          Icons.sports_basketball_sharp,
                                          size: constraints.maxHeight * .1,
                                        ),
                                        Row(
                                          mainAxisAlignment:
                                              MainAxisAlignment.center,
                                          children: const [
                                            Text('Quadra e Academia',
                                                style: TextStyle(
                                                  fontSize: 20,
                                                  color: Colors.black,
                                                ))
                                          ],
                                        ),
                                        Wrap(
                                          children: const [
                                            Padding(
                                              padding:
                                                  const EdgeInsets.all(25.0),
                                              child: Text(
                                                'Aqui você pode manter seu condicionamento, entre as opções "fitness" e "musculação", ideais para seu bem estar e qualidade de vida.',
                                                textAlign: TextAlign.justify,
                                                style: TextStyle(
                                                  color: Colors.black,
                                                ),
                                              ),
                                            ),
                                          ],
                                        )
                                      ],
                                    ),
                                  ),
                                ),
                              ],
                            ),
                            Container(
                                width: constraints.maxWidth * 1.5,
                                child: ElevatedButton(
                                    onPressed: () => Navigator.pushNamed(
                                        context, ListRoomsPage.route),
                                    child: Text("Ver quartos"))),
                          ],
                        ),
                      ),
                    ),
                  ],
                )));
      },
    );
  }
}
