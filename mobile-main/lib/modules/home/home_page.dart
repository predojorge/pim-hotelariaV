import 'package:boilerplate_flutter/models/room.dart';
import 'package:boilerplate_flutter/modules/datails_room/details_room_page.dart';
import 'package:boilerplate_flutter/modules/home/home_state.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:get_it/get_it.dart';

import 'home_content.dart';
import 'home_cubit.dart';

class HomePage extends StatelessWidget {
  static String route = '/home';

  const HomePage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return BlocProvider(
        create: (context) => GetIt.I.get<HomeCubit>(),
        child: BlocBuilder<HomeCubit, HomeState>(
          builder: (context, state) {
            return Scaffold(
                appBar: AppBar(
                  title: Text('Inicio'),
                  actions: [
                    IconButton(
                        onPressed: () =>
                            BlocProvider.of<HomeCubit>(context).logout(),
                        icon: Icon(Icons.logout))
                  ],
                ),
                body: HomeContent());
          },
        ));
  }
}

List<RoomModel> list = [
  RoomModel(
      title: 'Quarto Padrão',
      asset: 'padraoRoom.jpg',
      valor: 'R\$150,00',
      description:
          'Café da Manhã \n\nWi-Fi grátis \n\nAr-condicionado e Frigobar \n\nQuarto com TV \n\nCama de Solteiro',
      detail: 'Mais Barato'),
  RoomModel(
      title: 'Suíte',
      asset: 'suite.jpg',
      valor: 'R\$300,00',
      description:
          'Café da Manhã \n\nWi-Fi grátis \n\nAr-condicionado e Frigobar \n\nQuarto com TV \n\nCama de Casal + Cama Solteiro',
      detail: 'Mais Conforto'),
  RoomModel(
      title: 'Suíte Premium',
      asset: 'suitePremium.jpg',
      valor: 'R\$500,00',
      description:
          'Café da Manhã Especial \n\nWi-Fi grátis \n\nAr-condicionado e Frigobar \n\nQuarto e Sala com TV \n\nCama de Casal + Cama Solteiro + Hidromassagem ',
      detail: 'Melhor experiência'),
];
