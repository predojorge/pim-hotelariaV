import 'package:boilerplate_flutter/modules/datails_room/details_room_cubit.dart';
import 'package:boilerplate_flutter/modules/list_rooms/list_rooms_cubit.dart';
import 'package:dio/dio.dart';
import 'package:flutter_cache_manager/flutter_cache_manager.dart';
import 'package:get_it/get_it.dart';
import 'package:shared_preferences/shared_preferences.dart';

import 'data/user_repository.dart';
import 'environment.dart';
import 'modules/home/home_cubit.dart';
import 'modules/login/login_cubit.dart';
import 'modules/wrapper/wrapper_cubit.dart';
import 'shared/services/user_service.dart';

Future<void> configure() async {
  final sharedPreferences = await SharedPreferences.getInstance();
  GetIt.I.registerSingleton<BaseCacheManager>(DefaultCacheManager());

  GetIt.I
      .registerFactory<Dio>(() => Dio(BaseOptions(baseUrl: Environment.api)));

  GetIt.I.registerSingleton<UserService>(
      UserService(preferences: sharedPreferences));

  GetIt.I.registerSingleton<WrapperCubit>(WrapperCubit(
    userService: GetIt.I.get<UserService>(),
  ));

  GetIt.I.registerFactory<LoginCubit>(() => LoginCubit(
        userService: GetIt.I.get<UserService>(),
        userRepository: UserRepository(dio: GetIt.I.get<Dio>()),
      ));

  GetIt.I.registerFactory<HomeCubit>(() => HomeCubit(
        userService: GetIt.I.get<UserService>(),
      ));
  GetIt.I.registerFactory<ListRoomsCubit>(() => ListRoomsCubit());
  GetIt.I.registerFactory<DetailsRoomCubit>(() => DetailsRoomCubit());
}
